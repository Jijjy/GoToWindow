# Go To Window

[![Join the chat at https://gitter.im/christianrondeau/GoToWindow](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/christianrondeau/GoToWindow?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

> No more need for alt-tabbing through dozens of windows, or looking for your windows in the task bar. Simply press `Win` + `Tab` + `Tab`, type a few characters from the window title or process name you want to switch to and press enter. 

> For the keyboard maniacs.

**Warning! This is an alpha, and is stil being continuously improved.** Contributions are welcome!

[Official website](http://christianrondeau.github.io/GoToWindow/)

[Download latest release](https://github.com/christianrondeau/GoToWindow/releases)

## Usage

Launch `GoToWindow.exe`. You can also place it in in the Windows Startup menu to launch it automatically with Windows.

* Press `Win` + `Tab` + `Tab` to open the windows list. All windows are shown, with the most recently accessed first.

* Press the `Up` and `Down` arrows to navigate in the list, and press `Enter` to switch to the application.

* Start typing keywords to filter the list. Note that only windows that contain all words in either the window title _or_ the process name will be shown.

* If no opened window is found for your query, press `Enter` to search directly in the Windows Search charm.

* Press `Ctrl` + `Number (1 - 9)` to directly open the application at the selected index from the list.

* Press `Escape` to close the window.

## Tips and gotchas

* To use GoToWindow within an application that runs with elevated privileges (Run as Administrator), GoToWindow must also run with elevated privileges, otherwise the native `Alt` + `Tab` will show up.

* By default, GoToWindow expands web browser's tabs. This slows down display a little bit. You can disable it in the Settings, under the Plugins tab.

## Bugs

If for some reason Go To Window crashes, create an [issue](https://github.com/christianrondeau/GoToWindow/issues) (check if one already exists before).

Please include:

* Log (`GoToWindow.log` in the installation directory).<br />_Only include the last ~20 lines._
* Version of Windows
* Version of Go To Window

## Plugins

GoToWindow is extensible. Even the core functionality is a plug-in, that can be replaced if you wish. You can also write your own!

### Built-in Plugins

* `GoToWindow.Plugins.Core`: Loads the core windows list, as shown by the native `Alt` + `Tab` screen. Also allows launching the Windows Search if no window fit.
* `GoToWindow.Plugins.ExpandBrowsersTabs`: Expands browser windows and shows all tabs as separate windows. Includes Chrome, Firefox, Internet Explorer and Notepad++
* `GoToWindow.Plugins.ExplorerExtensions`: Show the full path of explorer windows instead of just the folder name. If a valid path is written, you can also open Windows Explorer with it.

### Installing Additional Plug-ins

Simply drop the plug-in files under `GoToWindow\Plugins` directory, and restart Go To Window.

### Writing your own Plug-ins

See the [Plugins](PLUGINS.md) document for more information on extending GoToWindow.

## Contributors

  * [Christian Rondeau](https://github.com/christianrondeau) - Main Developer
  * [David Cote](https://github.com/cotedav) - User Interface Design
  * [CoenraadS](https://github.com/CoenraadS) - Contributions

## License

Copyright (c) 2014 Christian Rondeau. Licensed under the [MIT license](LICENSE.md).
