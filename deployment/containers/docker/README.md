# .NET 5 REST API - docker

### How to exec Mongo Docker

- docker network create net5tutorial
- docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Password1 --network=net5tutorial mongo


### How to exec Net Docker

- docker build -t catalog:v1 .
- docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=Password1 --network=net5tutorial catalog:v1

## How to push Docker images

- docker images
- docker tag catalog:v1 felixmpa/catalog:v1
- docker push felixmpa/catalog:v1

## How to untag and delete

- docker rmi felixmpa/catalog:v1