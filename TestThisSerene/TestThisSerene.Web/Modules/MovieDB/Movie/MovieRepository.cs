

namespace TestThisSerene.MovieDB.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.MovieRow;
    using Entities;

    public class MovieRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> {
            protected override void AfterSave()
            {
                base.AfterSave();
                if (Row.CastList != null)
                {
                    var mc = Entities.MovieCastRow.Fields;
                    var oldList = IsCreate ? null : Connection.List<Entities.MovieCastRow>(mc.MovieId == this.Row.MovieId.Value);
                    new Common.DetailListSaveHandler<Entities.MovieCastRow>(
                        oldList, Row.CastList, x => x.MovieId = Row.MovieId.Value).Process(this.UnitOfWork);
                }
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest>{
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                if (!Request.Genres.IsEmptyOrNull())
                {
                    var mg = Entities.MovieGenresRow.Fields.As("mg");
                    query.Where(Criteria.Exists(
                        query.SubQuery()
                        .From(mg)
                        .Select("1")
                        .Where(
                            mg.MovieId == fld.MovieId &&
                            mg.GenreId.In(Request.Genres))
                            .ToString()));
                }
            }
        }
    }
}