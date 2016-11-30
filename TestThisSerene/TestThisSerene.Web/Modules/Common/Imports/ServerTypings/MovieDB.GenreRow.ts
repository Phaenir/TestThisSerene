namespace TestThisSerene.MovieDB {
    export interface GenreRow {
        GenreId?: number;
        Genre?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Genre';
        export const localTextPrefix = 'MovieDB.Genre';
        export const lookupKey = 'MovieDB.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('MovieDB.Genre');
        }

        export namespace Fields {
            export declare const GenreId: string;
            export declare const Genre: string;
        }

        ['GenreId', 'Genre'].forEach(x => (<any>Fields)[x] = x);
    }
}

