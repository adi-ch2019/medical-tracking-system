# Movies-frontend 1
FROM node:alpine as node
LABEL author="Aditya Naidu"
WORKDIR /app
COPY . /app


RUN npm install
WORKDIR /app
COPY . /app

EXPOSE 4200 49153
CMD npm run start
