using System.Collections.Generic;

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

	    public void Mutate(IDomainEvent evt)
        {
            ((dynamic)this).When((dynamic)evt);
        }
    }
}