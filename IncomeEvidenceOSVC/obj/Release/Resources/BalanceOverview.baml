   M S B A M L   `   `   `  ���� I  EMoney Control, Version=1.0.0.14, Culture=neutral, PublicKeyToken=nullK*clr-namespace:IncomeEvidenceOSVC.ResourcesIncomeEvidenceOSVC.Resources  M+clr-namespace:IncomeEvidenceOSVC.PropertiesIncomeEvidenceOSVC.Properties  2    ,IncomeEvidenceOSVC.Resources.BalanceOverview   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:IncomeEvidenceOSVC.Resources     @settings+clr-namespace:IncomeEvidenceOSVC.Properties     -     N� Title$  BalanceOverview��.��� -   $��OverviewGrid��$��20q� � RowDefinitions �� $��* ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $��DailyBalanceList��$��4��$��20(�����  �� 
TargetType" ��.�-   ��  �� Property � �� �� Value$ Stretch=� �� View �� .P��� $��Datum�� �� Width �� ,  &IncomeEvidenceOSVC.Properties.Settings   Default	 �� Source#	 Z 
 �� Path$
 DateColumnWidth� �� Mode$ TwoWay=� �� CellTemplate �� .R���  �� TextAlignment$ Right=�$
��10 0q�$��15(����� *Date+ �� StringFormat$ {0:d. MMMM yyyy}���� $��Příjmy�� �� #	 Z $
 IncomeColumnWidth�$ TwoWay=� �� .R��� $ Right=�$��0 0 10 0q�$��15(����� *Income+$ {0:C0}���� $��Výdaje�� �� #	 Z $
 CostsColumnWidth�$ TwoWay=� �� .R��� $ Right=�$��0 0 10 0q�$��15(����� *Costs+$ {0:C0}���� $��	Poznámky�� �� #	 Z $
 NoteColumnWidth�$ TwoWay=� �� .R��� $ Justify=�$��15(����� *Note+�� $��	Přílohy�� �� #	 Z $
 DocCountColumnWidth�$ TwoWay=� �� .R��� $ Center=�$��15(����� *DocumentCount+� $��1��$��4��$
��0 10q� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��Celkové příjmy: ��$��20(�$
��10 0q�$ Right=��� -   $��SummaryIncome��$��1��$
 Left=�$��20(��� $��Celkové výdaje: ��$��2��$��20(�$
��10 0q�$ Right=��� -   $��SummaryCosts��$��3��$
 Left=�$��20(��� $��Celkový zisk: ��$��4��$��20(�$
��10 0q�$ Right=��� -   $
��Gain��$��5��$
 Left=�$��20(��� -   $��NewRecordButton��$��1��$��2��$��30��$��10q�$��Přidat záznam��$	��100���� -	   $��RemoveRecordButton��$��1��$��2��$��2��$��30��$��10q�$��Smazat záznam��$	��100���� -
   $��EditRecordButton��$��1��$��4��$��2��$��30��$��10q�$��Upravit záznam��$	��100��