
namespace TestThisSerene.MovieDB {
    export interface GenreRow {
        GenreId?: number;
        Genre?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Genre';
        export const localTextPrefix = 'MovieDB.Genre';

        export namespace Fields {
            export declare const GenreId;
            export declare const Genre;
        }

        ['GenreId', 'Genre'].forEach(x => (<any>Fields)[x] = x);
    }
}

