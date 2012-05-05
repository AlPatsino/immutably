﻿using System;
using System.Collections.Generic;

namespace Escolar.Transitions
{
    public class InMemoryTransitionStreamWriter : ITransitionStreamWriter
    {
        private readonly InMemoryTransitionRepository _repository;
        private readonly Guid _streamId;

        public InMemoryTransitionStreamWriter(InMemoryTransitionRepository repository, Guid streamId)
        {
            _repository = repository;
            _streamId = streamId;
        }

        public void Write(IList<ITransition> transitions)
        {
            _repository.Append(transitions);
        }

        public void Write(params ITransition[] transitions)
        {
            _repository.Append(transitions);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}