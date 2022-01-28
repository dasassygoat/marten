// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Marten.Testing.Documents;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertUserFromBaseDocumentOperation1216401712
    public class UpsertUserFromBaseDocumentOperation1216401712 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Testing.Documents.UserFromBaseDocument _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertUserFromBaseDocumentOperation1216401712(Marten.Testing.Documents.UserFromBaseDocument document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_userfrombasedocument(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertUserFromBaseDocumentOperation1216401712
    
    
    // START: InsertUserFromBaseDocumentOperation1216401712
    public class InsertUserFromBaseDocumentOperation1216401712 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Testing.Documents.UserFromBaseDocument _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertUserFromBaseDocumentOperation1216401712(Marten.Testing.Documents.UserFromBaseDocument document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_userfrombasedocument(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertUserFromBaseDocumentOperation1216401712
    
    
    // START: UpdateUserFromBaseDocumentOperation1216401712
    public class UpdateUserFromBaseDocumentOperation1216401712 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Testing.Documents.UserFromBaseDocument _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateUserFromBaseDocumentOperation1216401712(Marten.Testing.Documents.UserFromBaseDocument document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_userfrombasedocument(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateUserFromBaseDocumentOperation1216401712
    
    
    // START: QueryOnlyUserFromBaseDocumentSelector1216401712
    public class QueryOnlyUserFromBaseDocumentSelector1216401712 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<Marten.Testing.Documents.UserFromBaseDocument>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyUserFromBaseDocumentSelector1216401712(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Documents.UserFromBaseDocument Resolve(System.Data.Common.DbDataReader reader)
        {

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = _serializer.FromJson<Marten.Testing.Documents.UserFromBaseDocument>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Documents.UserFromBaseDocument> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Documents.UserFromBaseDocument>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyUserFromBaseDocumentSelector1216401712
    
    
    // START: LightweightUserFromBaseDocumentSelector1216401712
    public class LightweightUserFromBaseDocumentSelector1216401712 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Documents.UserFromBaseDocument>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightUserFromBaseDocumentSelector1216401712(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Documents.UserFromBaseDocument Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = _serializer.FromJson<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Documents.UserFromBaseDocument> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightUserFromBaseDocumentSelector1216401712
    
    
    // START: IdentityMapUserFromBaseDocumentSelector1216401712
    public class IdentityMapUserFromBaseDocumentSelector1216401712 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Documents.UserFromBaseDocument>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapUserFromBaseDocumentSelector1216401712(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Documents.UserFromBaseDocument Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = _serializer.FromJson<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Documents.UserFromBaseDocument> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapUserFromBaseDocumentSelector1216401712
    
    
    // START: DirtyTrackingUserFromBaseDocumentSelector1216401712
    public class DirtyTrackingUserFromBaseDocumentSelector1216401712 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Documents.UserFromBaseDocument>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingUserFromBaseDocumentSelector1216401712(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Documents.UserFromBaseDocument Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = _serializer.FromJson<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Documents.UserFromBaseDocument> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Documents.UserFromBaseDocument document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Documents.UserFromBaseDocument>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingUserFromBaseDocumentSelector1216401712
    
    
    // START: QueryOnlyUserFromBaseDocumentDocumentStorage1216401712
    public class QueryOnlyUserFromBaseDocumentDocumentStorage1216401712 : Marten.Internal.Storage.QueryOnlyDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyUserFromBaseDocumentDocumentStorage1216401712(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Documents.UserFromBaseDocument document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Documents.UserFromBaseDocument document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyUserFromBaseDocumentSelector1216401712(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyUserFromBaseDocumentDocumentStorage1216401712
    
    
    // START: LightweightUserFromBaseDocumentDocumentStorage1216401712
    public class LightweightUserFromBaseDocumentDocumentStorage1216401712 : Marten.Internal.Storage.LightweightDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightUserFromBaseDocumentDocumentStorage1216401712(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Documents.UserFromBaseDocument document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Documents.UserFromBaseDocument document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightUserFromBaseDocumentSelector1216401712(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightUserFromBaseDocumentDocumentStorage1216401712
    
    
    // START: IdentityMapUserFromBaseDocumentDocumentStorage1216401712
    public class IdentityMapUserFromBaseDocumentDocumentStorage1216401712 : Marten.Internal.Storage.IdentityMapDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapUserFromBaseDocumentDocumentStorage1216401712(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Documents.UserFromBaseDocument document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Documents.UserFromBaseDocument document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapUserFromBaseDocumentSelector1216401712(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapUserFromBaseDocumentDocumentStorage1216401712
    
    
    // START: DirtyTrackingUserFromBaseDocumentDocumentStorage1216401712
    public class DirtyTrackingUserFromBaseDocumentDocumentStorage1216401712 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingUserFromBaseDocumentDocumentStorage1216401712(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Documents.UserFromBaseDocument document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertUserFromBaseDocumentOperation1216401712
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Documents.UserFromBaseDocument document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Documents.UserFromBaseDocument document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingUserFromBaseDocumentSelector1216401712(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingUserFromBaseDocumentDocumentStorage1216401712
    
    
    // START: UserFromBaseDocumentBulkLoader1216401712
    public class UserFromBaseDocumentBulkLoader1216401712 : Marten.Internal.CodeGeneration.BulkLoader<Marten.Testing.Documents.UserFromBaseDocument, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid> _storage;

        public UserFromBaseDocumentBulkLoader1216401712(Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Documents.UserFromBaseDocument, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_userfrombasedocument(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_userfrombasedocument_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_userfrombasedocument (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_userfrombasedocument_temp.\"id\", mt_doc_userfrombasedocument_temp.\"data\", mt_doc_userfrombasedocument_temp.\"mt_version\", mt_doc_userfrombasedocument_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_userfrombasedocument_temp left join public.mt_doc_userfrombasedocument on mt_doc_userfrombasedocument_temp.id = public.mt_doc_userfrombasedocument.id where public.mt_doc_userfrombasedocument.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_userfrombasedocument target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_userfrombasedocument_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_userfrombasedocument_temp as select * from public.mt_doc_userfrombasedocument limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Documents.UserFromBaseDocument document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Documents.UserFromBaseDocument document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: UserFromBaseDocumentBulkLoader1216401712
    
    
    // START: UserFromBaseDocumentProvider1216401712
    public class UserFromBaseDocumentProvider1216401712 : Marten.Internal.Storage.DocumentProvider<Marten.Testing.Documents.UserFromBaseDocument>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UserFromBaseDocumentProvider1216401712(Marten.Schema.DocumentMapping mapping) : base(new UserFromBaseDocumentBulkLoader1216401712(new QueryOnlyUserFromBaseDocumentDocumentStorage1216401712(mapping)), new QueryOnlyUserFromBaseDocumentDocumentStorage1216401712(mapping), new LightweightUserFromBaseDocumentDocumentStorage1216401712(mapping), new IdentityMapUserFromBaseDocumentDocumentStorage1216401712(mapping), new DirtyTrackingUserFromBaseDocumentDocumentStorage1216401712(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: UserFromBaseDocumentProvider1216401712
    
    
}

