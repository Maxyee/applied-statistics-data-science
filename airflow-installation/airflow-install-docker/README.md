### Installing Airflow With Docker

1. In the beginning we have to install Docker and Docker Compose into our machine.

The docker documentation website will help us to install the docker into our machine.
`https://docs.docker.com/get-docker/`

2. After installing the docker, create a folder called `airflow-docker` and then run a command to download airflow docker file 
airflow community already created the file for us. we just need to download the `.yaml` file and run it to our machine.


```bash
mkdir airflow-docker
cd airflow-docker

curl -LfO 'http://apache-airflow-docs.s3-website.eu-central-1.amazonaws.com/docs/apache-airflow/latest/docker-compose.yaml'
```

After running all the bash command we can find the docker composer file for airflow is downloaded into our folder

3. Now we will create our required folders for airflow and the environment

```bash
mkdir ./dags ./plugins ./logs
echo -e "AIRFLOW_UID=$(id -u)\nAIRFLOW_GID=0" > .env
```

4. Now everything set, we can run our docker composer

```bash
docker-compose up airflow-init
```

5. now we will run the docker-compose up

```bash
docker-compose up
```

6. lets check our docker airflow is running or not.

```bash
docker ps
```

7. After checking the status of docker airflow (healthy), we need to go to thr browser then `localhost:8080`

we will see our airflow is running.





