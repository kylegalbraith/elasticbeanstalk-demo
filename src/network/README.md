This folder contains the CloudFormation template `vpc.yaml` for defining a new VPC for your Elasticbeanstalk API.

Run the following [AWS CLI]() call from your command line:
```command
C:\>aws cloudformation --stack-name <your-stack-name> --template-body file://vpc.yaml
```

This will create a new VPC in your AWS account with the name of your stack. This VPC will consist of: 
* 2 Private subnets.
* 2 Public subnets.
* A internet gateway and route table for the public subnets.
* A NAT gateway and route table for the private subnets. 

In a load balanced environment, place your load balancers in one or more **public subnets**. Place your instances behind the load balancer in one or more **private subnets**.