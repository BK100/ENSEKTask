# ENSEK CSV Parser

Note - A frontend with CSV upload has been implemented, but data appears to be formatted incorrectly through some undetermined mechanism somewhere in the pipeline - as such, it is recommended to just send the CSV string data directly in a request object to the API controller. The frontend has been included as a proof of concept.

Example request JSON -

```
{
  "inputCsv": "AccountId,MeterReadingDateTime,MeterReadValue,\r\n2344,22\/04\/2019 09:24,1002,\r\n2233,22\/04\/2019 12:25,323,\r\n8766,22\/04\/2019 12:25,3440,\r\n2344,22\/04\/2019 12:25,1002,\r\n2345,22\/04\/2019 12:25,45522,\r\n2346,22\/04\/2019 12:25,999999,\r\n2347,22\/04\/2019 12:25,54,\r\n2348,22\/04\/2019 12:25,123,\r\n2349,22\/04\/2019 12:25,0,\r\n2350,22\/04\/2019 12:25,5684,\r\n2351,22\/04\/2019 12:25,57579,\r\n2352,22\/04\/2019 12:25,455,\r\n2353,22\/04\/2019 12:25,1212,\r\n2354,22\/04\/2019 12:25,889,\r\n2355,06\/05\/2019 09:24,1,\r\n2356,07\/05\/2019 09:24,0,\r\n2344,08\/05\/2019 09:24,0,\r\n6776,09\/05\/2019 09:24,-6575,\r\n6776,10\/05\/2019 09:24,23566,\r\n4534,11\/05\/2019 09:24,0,\r\n1234,12\/05\/2019 09:24,9787,\r\n1235,13\/05\/2019 09:24,0,\r\n1236,10\/04\/2019 19:34,8898,\r\n1237,15\/05\/2019 09:24,3455,\r\n1238,16\/05\/2019 09:24,0,\r\n1239,17\/05\/2019 09:24,45345,\r\n1240,18\/05\/2019 09:24,978,\r\n1241,11\/04\/2019 09:24,436,X\r\n1242,20\/05\/2019 09:24,124,\r\n1243,21\/05\/2019 09:24,77,\r\n1244,25\/05\/2019 09:24,3478,\r\n1245,25\/05\/2019 14:26,676,\r\n1246,25\/05\/2019 09:24,3455,\r\n1247,25\/05\/2019 09:24,3,\r\n1248,26\/05\/2019 09:24,3467,"
}
```
