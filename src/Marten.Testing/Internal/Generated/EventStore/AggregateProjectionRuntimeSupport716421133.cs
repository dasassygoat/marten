// <auto-generated/>
#pragma warning disable
using Marten;
using Marten.Events.Aggregation;
using Marten.Internal.Storage;
using Marten.Storage;
using System;
using System.Linq;

namespace Marten.Generated.EventStore
{
    // START: AggregateProjectionLiveAggregation716421133
    public class AggregateProjectionLiveAggregation716421133 : Marten.Events.Aggregation.SyncLiveAggregatorBase<Marten.Testing.Events.Aggregation.MyAggregate>
    {
        private readonly Marten.Events.Aggregation.AggregateProjection<Marten.Testing.Events.Aggregation.MyAggregate> _aggregateProjection;

        public AggregateProjectionLiveAggregation716421133(Marten.Events.Aggregation.AggregateProjection<Marten.Testing.Events.Aggregation.MyAggregate> aggregateProjection)
        {
            _aggregateProjection = aggregateProjection;
        }


        public System.Action<Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent1 {get; set;}

        public System.Action<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.BEvent> ProjectEvent2 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.CEvent, Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent3 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent4 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.Finished, bool> ShouldDelete1 {get; set;}


        public override Marten.Testing.Events.Aggregation.MyAggregate Build(System.Collections.Generic.IReadOnlyList<Marten.Events.IEvent> events, Marten.IQuerySession session, Marten.Testing.Events.Aggregation.MyAggregate snapshot)
        {
            if (!events.Any()) return null;
            Marten.Testing.Events.Aggregation.MyAggregate myAggregate = null;
            snapshot ??= Create(events[0], session);
            foreach (var @event in events)
            {
                snapshot = Apply(@event, snapshot, session);
            }

            return snapshot;
        }


        public Marten.Testing.Events.Aggregation.MyAggregate Create(Marten.Events.IEvent @event, Marten.IQuerySession session)
        {
            return new Marten.Testing.Events.Aggregation.MyAggregate();
        }


        public Marten.Testing.Events.Aggregation.MyAggregate Apply(Marten.Events.IEvent @event, Marten.Testing.Events.Aggregation.MyAggregate aggregate, Marten.IQuerySession session)
        {
            switch (@event)
            {
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.AEvent> event_AEvent72:
                    ProjectEvent1.Invoke(aggregate);
                    break;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.BEvent> event_BEvent73:
                    ProjectEvent2.Invoke(aggregate, event_BEvent73.Data);
                    break;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.CEvent> event_CEvent74:
                    aggregate = ProjectEvent3.Invoke(aggregate, event_CEvent74.Data);
                    break;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.DEvent> event_DEvent75:
                    aggregate = ProjectEvent4.Invoke(aggregate);
                    break;
            }

            return aggregate;
        }

    }

    // END: AggregateProjectionLiveAggregation716421133
    
    
    // START: AggregateProjectionInlineHandler716421133
    public class AggregateProjectionInlineHandler716421133 : Marten.Events.Aggregation.AggregationRuntime<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid>
    {
        private readonly Marten.IDocumentStore _store;
        private readonly Marten.Events.Aggregation.IAggregateProjection _projection;
        private readonly Marten.Events.Aggregation.IEventSlicer<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid> _slicer;
        private readonly Marten.Storage.ITenancy _tenancy;
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid> _storage;
        private readonly Marten.Events.Aggregation.AggregateProjection<Marten.Testing.Events.Aggregation.MyAggregate> _aggregateProjection;

        public AggregateProjectionInlineHandler716421133(Marten.IDocumentStore store, Marten.Events.Aggregation.IAggregateProjection projection, Marten.Events.Aggregation.IEventSlicer<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid> slicer, Marten.Storage.ITenancy tenancy, Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid> storage, Marten.Events.Aggregation.AggregateProjection<Marten.Testing.Events.Aggregation.MyAggregate> aggregateProjection) : base(store, projection, slicer, tenancy, storage)
        {
            _store = store;
            _projection = projection;
            _slicer = slicer;
            _tenancy = tenancy;
            _storage = storage;
            _aggregateProjection = aggregateProjection;
        }


        public System.Action<Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent1 {get; set;}

        public System.Action<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.BEvent> ProjectEvent2 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.CEvent, Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent3 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.MyAggregate> ProjectEvent4 {get; set;}

        public System.Func<Marten.Testing.Events.Aggregation.MyAggregate, Marten.Testing.Events.Aggregation.Finished, bool> ShouldDelete1 {get; set;}


        public override async System.Threading.Tasks.ValueTask<Marten.Testing.Events.Aggregation.MyAggregate> ApplyEvent(Marten.IQuerySession session, Marten.Events.Projections.EventSlice<Marten.Testing.Events.Aggregation.MyAggregate, System.Guid> slice, Marten.Events.IEvent evt, Marten.Testing.Events.Aggregation.MyAggregate aggregate, System.Threading.CancellationToken cancellationToken)
        {
            switch (evt)
            {
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.AEvent> event_AEvent76:
                    aggregate ??= new Marten.Testing.Events.Aggregation.MyAggregate();
                    ProjectEvent1.Invoke(aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.BEvent> event_BEvent77:
                    aggregate ??= new Marten.Testing.Events.Aggregation.MyAggregate();
                    ProjectEvent2.Invoke(aggregate, event_BEvent77.Data);
                    return aggregate;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.CEvent> event_CEvent78:
                    aggregate ??= new Marten.Testing.Events.Aggregation.MyAggregate();
                    aggregate = ProjectEvent3.Invoke(aggregate, event_CEvent78.Data);
                    return aggregate;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.DEvent> event_DEvent79:
                    aggregate ??= new Marten.Testing.Events.Aggregation.MyAggregate();
                    aggregate = ProjectEvent4.Invoke(aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Marten.Testing.Events.Aggregation.Finished> event_Finished80:
                    if (aggregate == null) return null;
                    var result_of_Invoke5 = ShouldDelete1.Invoke(aggregate, event_Finished80.Data);
                    if (result_of_Invoke5)
                    {
                        return null;
                    }

                    return aggregate;
            }

            return aggregate;
        }


        public Marten.Testing.Events.Aggregation.MyAggregate Create(Marten.Events.IEvent @event, Marten.IQuerySession session)
        {
            return new Marten.Testing.Events.Aggregation.MyAggregate();
        }

    }

    // END: AggregateProjectionInlineHandler716421133
    
    
}

