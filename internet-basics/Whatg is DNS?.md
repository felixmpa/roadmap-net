# What is DNS?
https://www.youtube.com/watch?v=mpQZVYPuDGU

# DNS - Domain Name System

NS, or Domain Name System, is a hierarchical and decentralized naming system for computers, services, or other resources connected to the Internet or a private network. It serves as the "phone book" for the Internet by translating human-friendly domain names (like www.example.com) into IP addresses (like 192.0.2.1), which are used for routing traffic across the Internet. Here’s a breakdown of how DNS works:

## Key Components:
#### Domain Name: 
A human-readable address (e.g., www.example.com) used to access websites.

#### IP Address: 
A numerical label assigned to each device connected to a computer network.

#### DNS Server: 
A server that stores a directory of domain names and their corresponding IP addresses.

## Process:

#### Query: 
When you enter a domain name into your web browser, a DNS query is sent to your Internet Service Provider’s (ISP) DNS server.
#### Resolution: 
The DNS server resolves the domain name into an IP address. If the ISP’s DNS server doesn't have the record, it queries other DNS servers until it finds the correct IP address.
#### Response: 
The IP address is sent back to your computer.
#### Connection: 
Your computer uses this IP address to connect to the server hosting the website you want to access.

### DNS Records:

#### A Record (Address Record): Maps a domain to an IPv4 address.
#### AAAA Record: Maps a domain to an IPv6 address.
#### MX Record (Mail Exchange): Defines mail servers for the domain.
#### CNAME Record (Canonical Name): Alias of one domain to another.
#### NS Record (Name Server): Specifies authoritative DNS servers for the domain.
#### PTR Record (Pointer Record): Used for reverse DNS lookups.

## Benefits:
#### User-Friendly Navigation: Allows users to access websites using easy-to-remember names instead of numerical IP addresses.
#### Load Balancing: Distributes incoming web traffic across multiple servers.
#### Redundancy: Provides fault tolerance and improves website accessibility.

