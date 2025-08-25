Game under comstruction!

Extract Torque.zip then put the Torque folder to your C:/ directory so your copy of EchoFlux: The Dimensions will work.
The game shortcut is located in the 'EchoFlux' folder.

(Warning! Online is experimental so it might not work.)
If you don't have I2P already, then go to 'Network folder' then run StartI2PdBrowser.bat to set up the I2Pd stuff.
After the bat file finished, then go you are set. That will pretty much set up the online side.
Now, lastly, if you want to use the online side, you will need to run i2pd.exe every time you do.
If you do have I2P, just add a tunnel for EchoFlux.

Tunnel details
-
[EchoFlux]
type = client
host = 127.0.0.1
port = 7656
inbound.length = 1
outbound.length = 1
i2cp.leaseSetType = 3
i2cp.leaseSetEncType = 4
destination port = 28000
keys = EcFx.dat

Note: Make sure to change the username from playernamehere to whatever you like.

PS: This will be more simplfied when I finally get things working.

Updated for PubA1...