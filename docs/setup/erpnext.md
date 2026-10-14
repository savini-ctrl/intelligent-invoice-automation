# ERPNext Docker Setup

## Project
Intelligent Invoice Processing & ERP Automation Agent

## Purpose
ERPNext is the test ERP system for automating purchase invoice processing using Power Automate Desktop.

## Technologies
- Docker Desktop
- ERPNext
- Power Automate Desktop
- Git and GitHub

## Installation

Clone the official Frappe Docker repository outside this project:

git clone https://github.com/frappe/frappe_docker.git

## Start ERPNext

Navigate to the frappe_docker directory:

docker compose -f pwd.yml up -d

## Check Containers

docker compose -f pwd.yml ps

## Access ERPNext

URL: http://localhost:8080

## Manual Purchase Invoice Test

Test supplier: Microsoft

Invoice number: INV-10001

Item: IT Services

Net amount: GBP 1,000

VAT rate: 20%

Expected VAT: GBP 200

Expected gross amount: GBP 1,200

## Next Steps
- Complete and verify the manual Purchase Invoice
- Build Dataverse invoice tables
- Implement AI Builder extraction
- Develop Power Automate Desktop ERP posting
- Build Copilot Studio agent