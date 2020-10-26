# MTS-frontend 1
FROM node:alpine as node
LABEL author="Aditya Naidu"
WORKDIR /app
COPY . /app


RUN npm install
WORKDIR /app
COPY . /app

RUN npm run --prod

