
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace TestThisSerene.MovieDB {
    
    @Serenity.Decorators.registerClass()
    export class PersonEditor extends Common.GridEditorBase<PersonRow> {
        protected getColumnsKey() { return 'MovieDB.Person'; }
        protected getDialogType() { return PersonEditorDialog; }
                protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}