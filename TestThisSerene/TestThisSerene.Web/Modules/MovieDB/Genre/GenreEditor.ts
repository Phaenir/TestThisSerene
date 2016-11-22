
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace TestThisSerene.MovieDB {
    
    @Serenity.Decorators.registerClass()
    export class GenreEditor extends Common.GridEditorBase<GenreRow> {
        protected getColumnsKey() { return 'MovieDB.Genre'; }
        protected getDialogType() { return GenreEditorDialog; }
                protected getLocalTextPrefix() { return GenreRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}