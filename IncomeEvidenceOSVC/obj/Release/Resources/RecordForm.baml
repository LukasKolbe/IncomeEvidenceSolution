   M S B A M L   `   `   `  ���� I  EMoney Control, Version=1.0.0.14, Culture=neutral, PublicKeyToken=nullK*clr-namespace:IncomeEvidenceOSVC.ResourcesIncomeEvidenceOSVC.Resources  -    'IncomeEvidenceOSVC.Resources.RecordForm   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:IncomeEvidenceOSVC.Resources     -     N� Title$  
RecordForm�� � 	Resources    Save �� Text��%   &	        �� $ x�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command# [   J� InputBindings �� 
 �� Key$ Return�� �� Command# [  .��� $��20q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �	 � ColumnDefinitions	 �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Zvolte datum záznamu: ��
 �� TextAlignment$
 Right=�$��2��$��10 30 10 10q�$��20(�(  "System.Windows.Controls.DatePicker  -   $
��Date��$��10 30 10 10q���.  $��2���� $��	Příjmy:��$��20(�$��1��$��10q�$
 Right=��� -   $��	IncomeTbx��$��1��$��1��$��0��$��10q�$��16(�$��Center=��� $��Výdaje:��$��20(�$��1��$��2��$��10q�$
 Right=��� -   $��CostsTbx��$��1��$��3��$��1��$��10q�$��16(�$��Center=��� $��
Poznámka:��$��20(�$��2��$��10q�$
 Right=��� -   $��NoteTbx�� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $��2��$��2��$��1��$��3��$��10q�$	��100���� $��3��$	��Top=�$��Right=�$��20(�$��10q�$��
Dokumenty:���� -   $��DocumentsList��$��3��$��1��$��2��$	��130��$��10q�����  �� 
TargetType" ��.�-   ���� .R��� ���� *Name+�� $��3��$��3��$��Center=�$��Center=�.+��� -	   $��30��$	��150��$��Přidat dokument��$��10q��� -
   $��30��$	��150��$��Zobrazit dokument��$��10q��� -   $��30��$	��150��$��Smazat dokument��$��10q��� -   $��SaveNewRecordButton��$��Uložit��$��4��$��1��$��30��$	��100��$��10q�$	��Top=��� -   $��OverwriteRecordButton��$��Uložit��$��4��$��1��$��30��$	��100��$��10q�$	��Top=��� -   $��Zrušit��$��4��$��2��$��30��$	��100��$��10q�$	��Top=�