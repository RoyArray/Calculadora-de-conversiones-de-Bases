<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora_de_conversiones_de_Bases.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Conversor de Bases</title>
    <!-- Bootstrap 5 CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow p-4">
                <h2 class="mb-4 text-center">Conversor de Bases</h2>

                <div class="mb-3">
                    <label for="txtNumero" class="form-label">Número:</label>
                    <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="ddlBaseOrigen" class="form-label">Base Origen:</label>
                    <asp:DropDownList ID="ddlBaseOrigen" runat="server" CssClass="form-select">
                        <asp:ListItem>Decimal</asp:ListItem>
                        <asp:ListItem>Binario</asp:ListItem>
                        <asp:ListItem>Octal</asp:ListItem>
                        <asp:ListItem>Hexadecimal</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <label for="ddlBaseDestino" class="form-label">Base Destino:</label>
                    <asp:DropDownList ID="ddlBaseDestino" runat="server" CssClass="form-select">
                        <asp:ListItem>Decimal</asp:ListItem>
                        <asp:ListItem>Binario</asp:ListItem>
                        <asp:ListItem>Octal</asp:ListItem>
                        <asp:ListItem>Hexadecimal</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="d-grid gap-2">
                    <asp:Button ID="btnConvertir" runat="server" Text="Convertir" OnClick="btnConvertir_Click" CssClass="btn btn-primary" />
                </div>

                <div class="mt-4">
                    <strong>Resultado:</strong>
                    <asp:Label ID="lblResultado" runat="server" CssClass="form-control-plaintext text-success fw-bold" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
