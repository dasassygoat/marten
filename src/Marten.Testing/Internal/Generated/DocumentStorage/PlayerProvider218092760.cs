// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Marten.Testing.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertPlayerOperation218092760
    public class UpsertPlayerOperation218092760 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Testing.Linq.Player _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertPlayerOperation218092760(Marten.Testing.Linq.Player document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_player(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session)
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

    // END: UpsertPlayerOperation218092760
    
    
    // START: InsertPlayerOperation218092760
    public class InsertPlayerOperation218092760 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Testing.Linq.Player _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertPlayerOperation218092760(Marten.Testing.Linq.Player document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_player(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session)
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

    // END: InsertPlayerOperation218092760
    
    
    // START: UpdatePlayerOperation218092760
    public class UpdatePlayerOperation218092760 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Testing.Linq.Player _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdatePlayerOperation218092760(Marten.Testing.Linq.Player document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_player(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session)
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

    // END: UpdatePlayerOperation218092760
    
    
    // START: QueryOnlyPlayerSelector218092760
    public class QueryOnlyPlayerSelector218092760 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<Marten.Testing.Linq.Player>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyPlayerSelector218092760(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Linq.Player Resolve(System.Data.Common.DbDataReader reader)
        {

            Marten.Testing.Linq.Player document;
            document = _serializer.FromJson<Marten.Testing.Linq.Player>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Linq.Player> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            Marten.Testing.Linq.Player document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Linq.Player>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyPlayerSelector218092760
    
    
    // START: LightweightPlayerSelector218092760
    public class LightweightPlayerSelector218092760 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<Marten.Testing.Linq.Player, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Linq.Player>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightPlayerSelector218092760(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Linq.Player Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            Marten.Testing.Linq.Player document;
            document = _serializer.FromJson<Marten.Testing.Linq.Player>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Linq.Player> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            Marten.Testing.Linq.Player document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Linq.Player>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightPlayerSelector218092760
    
    
    // START: IdentityMapPlayerSelector218092760
    public class IdentityMapPlayerSelector218092760 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<Marten.Testing.Linq.Player, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Linq.Player>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapPlayerSelector218092760(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Linq.Player Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Linq.Player document;
            document = _serializer.FromJson<Marten.Testing.Linq.Player>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Linq.Player> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Linq.Player document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Linq.Player>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapPlayerSelector218092760
    
    
    // START: DirtyTrackingPlayerSelector218092760
    public class DirtyTrackingPlayerSelector218092760 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<Marten.Testing.Linq.Player, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Linq.Player>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingPlayerSelector218092760(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Linq.Player Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Linq.Player document;
            document = _serializer.FromJson<Marten.Testing.Linq.Player>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Linq.Player> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Linq.Player document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Linq.Player>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingPlayerSelector218092760
    
    
    // START: QueryOnlyPlayerDocumentStorage218092760
    public class QueryOnlyPlayerDocumentStorage218092760 : Marten.Internal.Storage.QueryOnlyDocumentStorage<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyPlayerDocumentStorage218092760(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Linq.Player document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdatePlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Linq.Player document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyPlayerSelector218092760(session, _document);
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

    // END: QueryOnlyPlayerDocumentStorage218092760
    
    
    // START: LightweightPlayerDocumentStorage218092760
    public class LightweightPlayerDocumentStorage218092760 : Marten.Internal.Storage.LightweightDocumentStorage<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightPlayerDocumentStorage218092760(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Linq.Player document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdatePlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Linq.Player document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightPlayerSelector218092760(session, _document);
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

    // END: LightweightPlayerDocumentStorage218092760
    
    
    // START: IdentityMapPlayerDocumentStorage218092760
    public class IdentityMapPlayerDocumentStorage218092760 : Marten.Internal.Storage.IdentityMapDocumentStorage<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapPlayerDocumentStorage218092760(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Linq.Player document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdatePlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Linq.Player document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapPlayerSelector218092760(session, _document);
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

    // END: IdentityMapPlayerDocumentStorage218092760
    
    
    // START: DirtyTrackingPlayerDocumentStorage218092760
    public class DirtyTrackingPlayerDocumentStorage218092760 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingPlayerDocumentStorage218092760(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Linq.Player document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdatePlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertPlayerOperation218092760
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Linq.Player, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Linq.Player document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Linq.Player document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingPlayerSelector218092760(session, _document);
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

    // END: DirtyTrackingPlayerDocumentStorage218092760
    
    
    // START: PlayerBulkLoader218092760
    public class PlayerBulkLoader218092760 : Marten.Internal.CodeGeneration.BulkLoader<Marten.Testing.Linq.Player, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Linq.Player, System.Guid> _storage;

        public PlayerBulkLoader218092760(Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Linq.Player, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_player(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_player_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_player (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_player_temp.\"id\", mt_doc_player_temp.\"data\", mt_doc_player_temp.\"mt_version\", mt_doc_player_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_player_temp left join public.mt_doc_player on mt_doc_player_temp.id = public.mt_doc_player.id where public.mt_doc_player.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_player target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_player_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_player_temp as select * from public.mt_doc_player limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Linq.Player document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Linq.Player document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
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

    // END: PlayerBulkLoader218092760
    
    
    // START: PlayerProvider218092760
    public class PlayerProvider218092760 : Marten.Internal.Storage.DocumentProvider<Marten.Testing.Linq.Player>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public PlayerProvider218092760(Marten.Schema.DocumentMapping mapping) : base(new PlayerBulkLoader218092760(new QueryOnlyPlayerDocumentStorage218092760(mapping)), new QueryOnlyPlayerDocumentStorage218092760(mapping), new LightweightPlayerDocumentStorage218092760(mapping), new IdentityMapPlayerDocumentStorage218092760(mapping), new DirtyTrackingPlayerDocumentStorage218092760(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: PlayerProvider218092760
    
    
}

