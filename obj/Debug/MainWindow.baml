   M S B A M L   `   `   `  ????D  @LISTURLIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LISTURLIC	LISTURLIC  5   	       LISTURLIC.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LISTURLIC     5   	     ? Title$  Окно??5   	   $	??450??6   $	??800??6#    ? WindowStyle$
 None=?6/    ? WindowStartupLocation$ CenterScreen=?6B   ??5	      ?? 5
   
    ?? EndPoint$ 0.5,1&?6    ?? 
StartPoint$ 0.5,0&?6/   .??5      ?  ? Color$ 	#FFC5D8D4??6    ? Offset$ 0Q?6-   ? 5      $ 	#FFBDDAD4??6   $ 1Q?6-   ? 5      $ 	#FFD3EAE5??6   $ 0.522Q?6-   5      .??5      ? -   5        
??????  ? ColumnDefinitions 5   
   ?? 5      ?? 5      $??7* ?6   .+?5   
   ?? -   5         ??Name$ PoiscBtn??5      $??
Поиск??5      $??80??5      $	??Top=?5      $??0 100q?5      6   ?? 5   
   -   5        $ VhodBtn??5      $??Вход??5      $??80??5      $	??Top=?5       $??0 160q?5!      6   ? 5#   
   $??1??6   	 ? RowDefinitions	 5$      ?? 5%      ?? 5&      $??8* ?6    .+?5)      ?? $	??500??6   $??30??5*      $0??*Реестр юридических лиц??5+      $??25(?5,      $??Sitka Small)?6&   ? 5.      $
??auto??6   $??10??5/      $	??Top=?50      $??Right=?51      .+?52      ?? -   5        
 ??Name$
 SverBtn??52      $??ikonki/12346.png??53      $??0 0 10 0q?54      6*   ?? 55      -   5        $
 CloseBtn??55      $??ikonki/61155.png??56      6/   57       ? 59      -   5          ?Name$ Oknofr??59      $??1??5:      $??10q?5;      ???	#FFF1E7E7  ? NavigationUIVisibility$ Hidden=?5<      5=      5>      5?      