https://dotnettutorials.net/lesson/state-design-pattern/

The main goal here is to avoid if statements or switches in every method that go down different paths based on the current state.

This makes it much easier to find what happens when a job goes from one state to the other.  It also isolates changes better so that it is less likely that adding funcitonality to one state transition will break others.

You could use a full blown state machine library as well -> https://github.com/dotnet-state-machine/stateless