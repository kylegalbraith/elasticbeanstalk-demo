echo %1
curl -X POST -d @test.json -H "Content-Type: application/json" http://%1/api/demos
curl -X POST -d @test2.json -H "Content-Type: application/json" http://%1/api/demos
curl -X POST -d @test3.json -H "Content-Type: application/json" http://%1/api/demos
curl http://%1/api/demos