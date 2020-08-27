<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LBLHeader" runat="server" Text="Welcome to the application"></asp:Label>
            <br/>

            <asp:Label ID="LBLNAME" runat="server" Text="Full Name : "></asp:Label><br/>
            <asp:TextBox ID="TXTName" runat="server"></asp:TextBox><br/>

            <asp:Label ID="LBLPassword" runat="server" Text="Password : "></asp:Label><br/>
            <asp:TextBox ID="TXTPassword" runat="server"></asp:TextBox><br/>

            <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" /> &nbsp
            <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" /> &nbsp
            <asp:Button ID="BtnGV" runat="server" Text="View Data" OnClick="BtnGV_Click"/>



            
            <br />
            <br />
            <br />

                <asp:GridView ID="gvdetails" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="name" />
                        <asp:BoundField DataField="password" HeaderText="password" />
                    </Columns>
            </asp:GridView>


            
        </div>
    </form>
</body>
</html>
