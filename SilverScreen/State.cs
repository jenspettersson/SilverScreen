using System;
using System.Collections.Generic;
using SilverScreen.Domain;

namespace SilverScreen
{
    public class State : IState
    {
	    protected State()
	    {		    
	    }

	    protected State(IEnumerable<IDomainEvent> events)
	    {
		    foreach (var evt in events)
		    {
			    Mutate(evt);
		    }
	    }

	    public IIdentity Id { get; private set; }

	    public void Mutate(IDomainEvent evt)
        {
            ((dynamic)this).When((dynamic)evt);
        }
    }
}