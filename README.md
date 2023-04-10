# MetaMoodSln

In order to get this web application up and running, an NGINX web server is first needed.

First, do sudo vi /etc/nginx/sites-available/default after downloading NGINX and setting it up.

In this file, copy paste the following code:

server {

        # SSL configuration
        listen 443 ssl http2 default_server;
        listen [::]:443 ssl http2 default_server;
        include snippets/self-signed.conf;
        include snippets/ssl-params.conf;

        root /var/www/webapp/wwwroot;
        try_files $uri $uri/ /index.html =404;
        index index.html;

        server_name <INSERT FQDN HERE>;

}

server {
        listen 80 default_server;
        listen [::]:80 default_server;
        server_name <INSERT FQDN HERE>;
        return 302 https://$server_name$request_uri;
}
  
Also, type sudo mkdir /var/www/html/webapp. This is where the static files will be stored that will be served to the client.
  
Make sure to restart the nginx service with sudo service nginx reload. 
  
From there, create another folder at /var/www/html/MetaMood. Pull this git repo into that folder. Type dotnet publish -c Release -o /var/www/webapp to publish the files into the proper folder.

Now, the static files should be served correctly and the web application should be functioning. However, this application depends on both an API and a MySQL database, so those also have to be set up for the application to function. 
  
