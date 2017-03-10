# powerhour-errorlogging
Solution files for the Power Hour episode focused on SOLID

In this episode of Teleios Power Hour, developers are going to apply the SOLID principles to an exercise in error logging. 
There'll be two starting projects, one that has a more SOLID approach and one that is less so. 
The episode will focus on how easy or not, it is to extend initial requirements having started off with SOLID. 
The requirements are listed below. The episode will focus on making Requirements 2 come to life.

#Requirement 1: 
Error Log Sender App

Request 1
Send error logs via email to a manager. 
Read a text file with errors logs, the file will have the following format in each line
[title], [message], [timestamp]
Once the file is read an email with the list of errors will be sent to a manager.

Request 2
Support XML formatted error logs. The XML file will contain the following format
<errors>
                <error>
                                <title>[title]</title>
                                <message>[message]</message>
                                <timestamp>[timestamp]</timestamp>
                </error>
                <error>
                                <title>[title]</title>
                                <message>[message]</message>
                                <timestamp>[timestamp]</timestamp>
                </error>
</errors>

Request 3
Support logs stored in a database. The DB will have an error table with title, message and timestamp.

Request 4
Support posting the error messages to Slack/ Teams as well as sending email.

#Requirement 2:

1. Create unit tests for all previous requirements.
For all reqs going forward use these tests and add to them, where possible.
2. Send logs to different destinations, depending on category.
3. Enable reading a log to the event log
