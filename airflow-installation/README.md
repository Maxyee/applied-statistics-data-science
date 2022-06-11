# Apache Airflow Installation

we can install the apache airflow in many ways like
1. using python pip
2. using docker
3. using Kubernetes with Helm


### Installing Airflow With Python3 Pip

```bash
python3 -m venv env_airflow
source env_airflow/bin/activate
pip3 install apache-airflow==1.10.9

```

##### By default airflow installed the sqllite database in it. As a result we are going to use it.

```bash
airflow initdb
```
This command will initialize the sqllite database into our airflow

##### Now we are going to create a folder called `dags`

```bash
mkdir dags
```

Into this dag folder we will use our own pipline models or dag codes.


##### for using airflow with sqllite and sequential exicutor. we need to run two command

```bash
airflow webserver
airflow scheduler
```