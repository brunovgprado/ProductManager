FROM microsoft/mssql-server-linux:latest

RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

COPY ./dbsettings /usr/src/app

RUN chmod +x /usr/src/app/import-data.sh

USER root

ENV ACCEPT_EULA="Y"
ENV MSSQL_SA_PASSWORD="Produto12345678"

RUN ( /opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'Produto12345678' -i /usr/src/app/setup.sql \
    && pkill sqlservr 

#CMD /bin/bash ./entrypoint.sh

# USER root

# CMD /bin/bash ./dbsettings/entrypoint.sh

# COPY ./dbsettings /

#ENTRYPOINT [ "/bin/bash", "entrypoint.sh" ]
# CMD [ "/opt/mssql/bin/sqlservr" ]