# Customer Preference Centre
This document will examine the system to create a marketing report generator which takes into account customers preferences for
receiving marketing information.

## Background
This system is just the domain code with a couple of tests which can be run and debugged,
I wasn't sure what kind of system was needeed for the spec so I've left it relatively
open ended and didn't build one and left it open for implementation (GUI, console, WebUI, API ect).

Otherwise just the domain logic will suffice. I have created an ExampleOutput.txt to
present what the main test of this system produces.

## System
The system is relatively simple, we have a ```MarketingPreference``` class which we 
override to create each type of marketing preference; as we know the customer can
only have one this makes it easy, ensure that we can override the ```SendMarketing``` method
so that every instance of the ```MarketingPreference``` can be used to figure out
if marketing should be sent on that day.

We have four types of marketing preference, ```DayOfTheWeek, DayOfTheMonth, Never and EveryDay```
the never and every day types are really simple; we can just override the ```SendMarketing``` method to 
to be false and true respectively.

The other two are a bit more complex, day of the month we just pass the ```int``` day we
expect to see marketing, and day of the week we pass in a list of days the customer
would like to receive marketing, we assume that if they're not in this list then
we don't want marketing.

The report generator is pretty simple, we give it some inputs and let it iterate over
the day range and use the overridden ```SendMarketing``` method to evaluate if we should add it to our marking list. 
We add the correct format using ```Print``` methods.

We then have an end-to-end test taking all of the above and creating architypes for
each customer, we could have tests for each one but it doesn't really matter for a PoC;
in a more production ready system we could create more tests but I feel it is somewhat
overkill as the implementations are all tested here.

## Conclusion
A pretty fun task really, got to use polymorphism.
