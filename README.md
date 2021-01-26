# Task Logger

Task Logger is a DotNet Api Project with a react frontend.

- Monitor Tasks based on a timer
- Update the color of the clock

## Technology Stack

Lead Manager uses a number of open source projects to work properly:

### Frontend

- [React.js][reactjs] - A javascript library for building user interfaces.
- [Redux][redux] - A predictable state container for JS apps - one source of truth.
- [React-Redux][reactredux] - A library with React bindings for Redux.
- [Axios][axios] - Promise based HTTP client for the browser.
- [Booststrap][bootstrap] - A css framework for designing webpages.

### Backend

- [DotNet][django] - A python based backend framework for business logic.
- [Asp.Net][djangorestframework] - A powerful flexible toolkit for building Web.

### Database

- [PostgreSQL][postgresql] - An open source relational database

And of course Lead Manager itself is open source with a [public repository][githubpage]
on GitHub.

## Installation

Dillinger requires [Node.js](https://nodejs.org/) v10+ to run.
We will be using [yarn](https://yarnpkg.com/) package manager.

Unzip the application.

<!--
```sh
# Clone the github repo, you must have git installed locally
$ git clone https://github.com/isnakolah/lead_manager.git

``` -->

Installation procedure for Mac and Linux based systems

Install the node dependencies and devDependencies.
Current directory: **\$**

```sh
# Change directory to the lead_manager base directory
$ cd client

# Install all the dependency
$ yarn add -d

```

Install the node dependencies and devDependencies.
Current directory: **\$** _client/_

```sh
# Change the directory to the dotnet project
$ cd ../.
$ cd server/

# Download the the dependencies
$ dotnet restore

# Setup the db by changing the connection string
"Host=localhost;Port=5432;Username=<username>;Password=<password></password>;Database=<taskdb>"

```

<!-- **Use the .env-example in lead_manager/lead_manager/.env-example to configure your db** -->

## Running the application

Open a seperate terminal in the base folder for this project **\$** _server/_

```sh
# In the base directory of the project, run the dev script
$ yarn run dev

```

**Open [http://127.0.0.1:8000/#/](http://127.0.0.1:8000/#/)**

## License

MIT

**Free Software, Hell Yeah!**

## Developer

**By [Nakolah Daniel](https://www.linkedin.com/in/danielnakolah)**

[//]: # "These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax"
[reactjs]: https://reactjs.org/
[django]: https://www.djangoproject.com/
[djangorestframework]: https://www.django-rest-framework.org/
[redux]: https://redux.js.org//
[reactredux]: https://react-redux.js.org/
[djangorestknox]: https://pypi.org/project/django-rest-knox/
[githubpage]: https://github.com/isnakolah/lead_manager
[bootstrap]: https://getbootstrap.com/
[postgresql]: https://www.postgresql.org/
[axios]: https://www.npmjs.com/package/axios
