﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using OpenReport.Attributes.Table;
using OpenReport.Layouts.Elements.Base;
using OpenReport.Layouts.Elements.Components;
using OpenReport.Styles;

namespace OpenReport.Test
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var header = new HeaderElement
            {
                Header = "RELATÓRIO DE PRODUTOS",
                HeaderTop = "EMPRESA DE EMPREENDIMENTOS LTDA."
            };

            var table = new TableElement<Produto>(new List<Produto>()
            {
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Hamburger", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Pão Carioca", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Rapadura", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de leite", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Doce de coco", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Geleia de mocotó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Açúcar", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Leite em pó", VR_Unitario = 10.5m, VR_Venda = 10.5m * 1.3m },
                new Produto() { CH_Nome = "Chocolate em pó", VR_Unitario = 8.75m, VR_Venda = 8.75m * 1.3m },
                new Produto() { CH_Nome = "Iogurte 500ML", VR_Unitario = 4.1m, VR_Venda = 4.1m * 1.3m }
            });

            var document = new DocumentElement
            {
                HeaderText = header.Header,
                Content = header.Render() + table.Render()
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ORDocumentViewer(document));
        }
    }

    [TableStyle(TableStyle.Striped)]
    public class Produto
    {
        [TableColumnHeader("Descrição")]
        [TableColumnSize(50)]
        public string CH_Nome { get; set; }

        [TableColumnHeader("Vlr. Unitário")]
        public decimal VR_Unitario { get; set; }

        [TableColumnHeader("Vlr. Venda")]
        [TableColumnTotalize(ColumnFormatStyle.Decimal)]
        public decimal VR_Venda { get; set; }
    }
}
