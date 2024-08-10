ASP.NET CORE
ROUTING
********

A nechanism that inspect the incoming Requests (ie.URLs) and then mapped that request to the controllers and their action methods.
1. Mapping is done by Routing Rules that are added to the request processing pipeline for the app.
1. ASP.NET Framework connects / maps the incoming Request to Controller and their action methods based on routes configured in the app.
1. Two Types of Routing
	a. Convention Based Routing
		The route is determined based on the convention defined in route Templates;
		app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
		that maps the incoming URL request to controller and its action method.
	b. Defined in Program.cs 
	c. Controller Action Methods handels the request.
	b. Attribute Based Routing.
		a . [Route] attribute is used to define the routes.
		b . [Route] can be configured either at the Controller level or at the Action method level.
		c. Both Conventional and Attribute Routing can be utilized in a single App.
		d. Route Templates are not effected by Controller or Action method name change.
		e. Token can be used as a place holder for both Controller and Action Method individually or simultaneously, such as,
			a [controller]
			a [action]
			a [controller]/[action]
