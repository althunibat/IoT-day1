#!/usr/local/bin/python
import time
import requests
import Adafruit_DHT
import os
import datetime

url = os.environ["API_URL"]
sensor = Adafruit_DHT.DHT11
pin = 4
try:
    while True:
        humidity, temperature = Adafruit_DHT.read_retry(sensor, pin)
        myResponse = requests.post(url, json={"timestamp": datetime.datetime.now().isoformat(), "humidity": humidity, "temperature": temperature})
        time.sleep(5)
except KeyboardInterrupt:
    print('Ended!')

