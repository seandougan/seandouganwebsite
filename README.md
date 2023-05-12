# Sean Dougan Portfolio Site

### About the Structure
- Started here with a standard MVC template.
- Overall Took a lot of work to rip out all of the bloat.
- Local Copies of Bootstrap and Jquery, Validation, Unobtrusive Removed.
- Now installs frontend dependencies with NodeJS - src folder is content root.
- Now uses page ViewModel structure instead of ViewBag
- Typescript and Sass added - build tools with WebPack for bundle and minification
- MSBuild integration with Node Scripts
- DTO's meant to be flattened Entity/Models
- View Models meant to be page level state-containers, and/or flattened DTO's
- BaseController and BaseModel implementation for compliance with Liskov Principle
- Services that are used by any consumer are segregated by their interface and their usage do not depend on concretions, the abstractions folder holds everything a consumer needs to know

### Purpose
This is just a landing to my personal page; introduce you to a little about me and a small bit of my work

### Build Instructions
1. npm install
2. npm run build will generate the dist folder manually, however the npm scripts have been integrated with MSBuild and is not necessary to run the project
3. Select the solution and Run the Application in Debug or Development Mode

### Production Build

To Come