
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace TestThisSerene.MovieDB {
    
    @Serenity.Decorators.registerClass()
    export class MovieCastEditor extends Common.GridEditorBase<MovieCastRow> {
        protected getColumnsKey() { return 'MovieDB.MovieCast'; }
        protected getDialogType() { return MovieCastEditorDialog; }
                protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
                }
        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id)) return false;
            row.PersonFullname = PersonRow.getLookup().itemById[row.PersonId].FullName;
            return true;
        }
    }
}