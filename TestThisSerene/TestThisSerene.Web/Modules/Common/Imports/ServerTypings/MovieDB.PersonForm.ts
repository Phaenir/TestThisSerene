namespace TestThisSerene.MovieDB {
    export class PersonForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Person';

    }

    export interface PersonForm {
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        FullName: Serenity.StringEditor;
        Birthdate: Serenity.DateEditor;
        BirthPlace: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        Height: Serenity.IntegerEditor;
    }

    [['FirstName', () => Serenity.StringEditor], ['LastName', () => Serenity.StringEditor], ['FullName', () => Serenity.StringEditor], ['Birthdate', () => Serenity.DateEditor], ['BirthPlace', () => Serenity.StringEditor], ['Gender', () => Serenity.EnumEditor], ['Height', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(PersonForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

