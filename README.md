# Early warning
*Under development. Not ready for use.*

*Em desenvolvimento. N�o est� pronto para uso.*


# Open Report
Biblioteca em .NET Framework para exibi��o de relat�rios utilizando HTML.

**Exemplo**

```csharp
[TableStyle(TableStyle.Striped)]
public class Produto
{
    [TableColumnHeader("Descri��o")]
    [TableColumnSize(50)]
    public string CH_DescricaoComercial { get; set; }

    [TableColumnHeader("Qtd. Estoque")]
    [TableColumnTotalize(ColumnFormat.Integer)]
    public int IN_Estoque { get; set; }
}
```

![exemple](OpenReportExample.png?raw=true)