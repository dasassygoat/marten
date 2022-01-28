// <auto-generated/>
#pragma warning disable
using Marten.Internal.CompiledQueries;
using Marten.Linq.QueryHandlers;
using Marten.Testing.Linq.Compiled;
using System;

namespace Marten.Generated.DocumentStorage
{
    // START: UserCountByFirstNameCompiledQuery330003048
    public class UserCountByFirstNameCompiledQuery330003048 : Marten.Internal.CompiledQueries.StatelessCompiledQuery<int, Marten.Testing.Linq.Compiled.UserCountByFirstName>
    {
        private readonly Marten.Linq.QueryHandlers.IQueryHandler<int> _inner;
        private readonly Marten.Testing.Linq.Compiled.UserCountByFirstName _query;
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;

        public UserCountByFirstNameCompiledQuery330003048(Marten.Linq.QueryHandlers.IQueryHandler<int> inner, Marten.Testing.Linq.Compiled.UserCountByFirstName query, Marten.Internal.CompiledQueries.HardCodedParameters hardcoded) : base(inner, query, hardcoded)
        {
            _inner = inner;
            _query = query;
            _hardcoded = hardcoded;
        }



        public override void ConfigureCommand(Weasel.Postgresql.CommandBuilder builder, Marten.Internal.IMartenSession session)
        {
            var parameters = builder.AppendWithParameters(@"select count(*) as number from public.mt_doc_user as d where d.data ->> 'FirstName' = ?");

            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[0].Value = _query.FirstName;
        }

    }

    // END: UserCountByFirstNameCompiledQuery330003048
    
    
    // START: UserCountByFirstNameCompiledQuerySource330003048
    public class UserCountByFirstNameCompiledQuerySource330003048 : Marten.Internal.CompiledQueries.CompiledQuerySource<int, Marten.Testing.Linq.Compiled.UserCountByFirstName>
    {
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;
        private readonly Marten.Linq.QueryHandlers.IQueryHandler<int> _queryHandler;

        public UserCountByFirstNameCompiledQuerySource330003048(Marten.Internal.CompiledQueries.HardCodedParameters hardcoded, Marten.Linq.QueryHandlers.IQueryHandler<int> queryHandler)
        {
            _hardcoded = hardcoded;
            _queryHandler = queryHandler;
        }



        public override Marten.Linq.QueryHandlers.IQueryHandler<int> BuildHandler(Marten.Testing.Linq.Compiled.UserCountByFirstName query, Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.UserCountByFirstNameCompiledQuery330003048(_queryHandler, query, _hardcoded);
        }

    }

    // END: UserCountByFirstNameCompiledQuerySource330003048
    
    
}

