﻿namespace TestThisSerene.MovieDB {
    export class GenreForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Genre';

    }

    export interface GenreForm {
        Genre: Serenity.StringEditor;
    }

    [['Genre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenreForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

