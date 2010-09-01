Follow these steps to autocommit to the git repository on every successful build:

1) Put the snippet from "Post-build_event_command_line.txt" into your Dojo project:

Project Properties
  -> Build Events
    -> Post-build event command line: <<INSERT SNIPPET IN TEXTBOX>>

2) Let the command line run on successful builds:

Project Properties
  -> Build Events
    -> Run the post-build event: On successful build
