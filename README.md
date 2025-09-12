# overview-.net-maui-listview
Overview of .NET MAUI ListView

## Sample

```xaml
<syncfusion:SfListView x:Name="listView" 
                    ItemsSource="{Binding CategoryList}"                         
                    Padding="0,5,0,5"                         
                    SelectionMode="None"                         
                    Background="#f2f2f1"                         
                    ItemSpacing="5,3,5,3" 
                    ItemSize="100">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <Grid  BackgroundColor="White" Padding="1">
                <Grid.RowDefinitions>
                    <RowDefinition Height="100"/>
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="100" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>

                <Image Grid.Column="0" Grid.Row="0" Source="{Binding Image}" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" Aspect="Fill"/>

                <Grid Grid.Row="0" Grid.Column="1" Padding="10,0,0,0">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>
                    <code>
                    . . .
                    . . .
                    <code>
                </Grid>
            </Grid>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
```
