
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace TestThisSerene.MovieDB {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MovieCastEditorDialog extends Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
                protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
                protected getNameProperty() { return MovieCastRow.nameProperty; }

                protected form: MovieCastForm;
                constructor() {
                    super();
                    this.form = new MovieCastForm(this.idPrefix);
                }
    }
}