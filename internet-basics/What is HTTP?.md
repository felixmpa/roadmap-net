# What is HTTP?
https://www.youtube.com/watch?v=iYM2zFP3Zn0

## HTTP

- Hyper Text Transfer Protocol
- Communication between web servers and clients.
- HTTP requests / responses
- Loading pages, form submit, ajaxs calls.

## HTTP IS STATELESS

- Every request is completly independant.
- Similar to transactions.
- Programming, Local Storage, Cookies, Sessions are used to create enhanced user experiences.

## WHAT IS HTTPS?

- Hyper Text Transfer Protocol Secure
- Data sent is encrypted
- SSL / TLS
- Install certificate on web host.

## HTTP METHODS

- GET: retrieves data from the server.
- POST: submit data to the server.
- PUT: Update data already on the server.
- DELETE: deletes data from the server.

## HTTP HEADER FIELDS

- General: URL, Method, Status Code, Remote Address, Referrer Policy.
- Response: Server, Set-Cookie, Content-Type, Content-Length, Date.
- Request: Cookies, Accept-xxx, Content-Type, Authorization, User-Agent, Referrer.

## HTTP STATUS CODE

HTTP response status codes indicate whether a specific HTTP request has been successfully completed. Responses are grouped in five classes:

- Informational responses (100 – 199)
- Successful responses (200 – 299)
- Redirection messages (300 – 399)
- Client error responses (400 – 499)
- Server error responses (500 – 599)

For example: 
 - 200 OK
 - 201 OK created
 - 301 Moved to new URL
 - 304 Not Modifed (Cached version)
 - 400 Bad Request
 - 404 Unauthorized
 - 404 Not Found
 - 500 Internal server error.

https://developer.mozilla.org/en-US/docs/Web/HTTP/Status

## HTTP / 2

- Major revsion of HTTP
- Under the hood changes
- Respond with more data
- Reduce latencyu by enabling full request and response multiplexing
- Fast, efficient and secure.


