   M S B A M L   `   `   `  ????I  EPremiereAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PremiereAppWPFPremiereAppWPF  5   	       PremiereAppWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PremiereAppWPF     5   	   -   5          ? Title$  Première application WPF??5   	   $	??350??6*   $	??500??67   
????? ? ? WindowStartupLocation$ CenterScreen=?5	   	   .??5
      ? -   5         ?Name$ MainGrid??5
       ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ??5   
   ?? 5      .??5      ?  ? Offset$	 0.0Q?6    ? Color$ Violet??6,   ? 5      $	 0.3Q?6   $ Yellow??6,   ? 5      $	 0.7Q?6   $	 Red??6,   ? 5      $	 1.0Q?6   $
 Blue??6,   5      .+?5   
   ?? -   5         ??Name$ Question??5      $	??Top=?6$   $#??Que pensez-vous de vous même??6<   $??0??6a   $	??115??6n   $??
19,31,18,0q?6{   ?? 5   
   -   5         ??Name$ button??5      $??Demander la réponse??6!   $??center=?6?   $??Center=?5      $	??154??6,   $??1??68   6E   ?? 5   
   -   5        $ txtBoxReponse??5      $??Ecrire ici votre question??6)   $??2??6K   $??Center=?5      $??98??6-   $??	19,0,18,0q?69   5      5!      