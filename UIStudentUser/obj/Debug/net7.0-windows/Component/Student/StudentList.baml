   M S B A M L   `   `   `  ����H  DUIStudentUser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:UIStudentUser.Component.StudentUIStudentUser.Component.Student  5      1    +UIStudentUser.Component.Student.StudentList   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:UIStudentUser.Component.Student     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  students��5
         AutoGenerateColumns$
 True��6=   ��6%   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      
IsReadOnly$
 True��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Id+  5      $
 Name��6%   $
 True��63    6E   �� *
FullName+  5      $ Course��6%   $
 True��65    6G   �� *Course+5      5      5      