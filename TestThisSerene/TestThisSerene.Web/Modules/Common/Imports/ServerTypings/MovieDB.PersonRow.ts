namespace TestThisSerene.MovieDB {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        LastName?: string;
        Birthdate?: string;
        BirthPlace?: string;
        Gender?: Modules.MovieDB.Person.Gender;
        Height?: number;
        FullName?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'MovieDB.Person';
        export const lookupKey = 'MovieDB.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('MovieDB.Person');
        }

        export namespace Fields {
            export declare const PersonId: string;
            export declare const FirstName: string;
            export declare const LastName: string;
            export declare const Birthdate: string;
            export declare const BirthPlace: string;
            export declare const Gender: string;
            export declare const Height: string;
            export declare const FullName: string;
        }

        ['PersonId', 'FirstName', 'LastName', 'Birthdate', 'BirthPlace', 'Gender', 'Height', 'FullName'].forEach(x => (<any>Fields)[x] = x);
    }
}

