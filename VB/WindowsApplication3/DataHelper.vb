Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXSample
	Friend Class DataHelper
		Public Shared Function CreateEmptyTable() As DataTable
			Dim table As New DataTable()
			table.Columns.Add("AnyColumn", GetType(String))

			Return table
		End Function

		Public Shared Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow
			table.Columns.Add("CustomerID", GetType(System.String))
			table.Columns.Add("CompanyName", GetType(System.String))
			table.Columns.Add("ContactName", GetType(System.String))
			table.Columns.Add("ContactTitle", GetType(System.String))
			table.Columns.Add("Address", GetType(System.String))
			table.Columns.Add("City", GetType(System.String))
			table.Columns.Add("Region", GetType(System.String))
			table.Columns.Add("PostalCode", GetType(System.String))
			table.Columns.Add("Country", GetType(System.String))
			table.Columns.Add("Phone", GetType(System.String))
			table.Columns.Add("Fax", GetType(System.String))
			dataRow = table.NewRow()
			dataRow("CustomerID") = "ALFKI"
			dataRow("CompanyName") = "Alfreds Futterkiste"
			dataRow("ContactName") = "Maria Anders"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Obere Str. 57"
			dataRow("City") = "Berlin"
			dataRow("Region") = ""
			dataRow("PostalCode") = "12209"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "030-0074321"
			dataRow("Fax") = "030-0076545"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "ANATR"
			dataRow("CompanyName") = "Ana Trujillo Emparedados y helados"
			dataRow("ContactName") = "Ana Trujillo"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Avda. de la Constitución 2222"
			dataRow("City") = "México D.F."
			dataRow("Region") = ""
			dataRow("PostalCode") = "05021"
			dataRow("Country") = "Mexico"
			dataRow("Phone") = "(5) 555-4729"
			dataRow("Fax") = "(5) 555-3745"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "ANTON"
			dataRow("CompanyName") = "Antonio Moreno Taquería"
			dataRow("ContactName") = "Antonio Moreno"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Mataderos  2312"
			dataRow("City") = "México D.F."
			dataRow("Region") = ""
			dataRow("PostalCode") = "05023"
			dataRow("Country") = "Mexico"
			dataRow("Phone") = "(5) 555-3932"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "AROUT"
			dataRow("CompanyName") = "Around the Horn"
			dataRow("ContactName") = "Thomas Hardy"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "120 Hanover Sq."
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "WA1 1DP"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-7788"
			dataRow("Fax") = "(171) 555-6750"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BERGS"
			dataRow("CompanyName") = "Berglunds snabbköp"
			dataRow("ContactName") = "Christina Berglund"
			dataRow("ContactTitle") = "Order Administrator"
			dataRow("Address") = "Berguvsvägen  8"
			dataRow("City") = "Luleå"
			dataRow("Region") = ""
			dataRow("PostalCode") = "S-958 22"
			dataRow("Country") = "Sweden"
			dataRow("Phone") = "0921-12 34 65"
			dataRow("Fax") = "0921-12 34 67"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BLAUS"
			dataRow("CompanyName") = "Blauer See Delikatessen"
			dataRow("ContactName") = "Hanna Moos"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Forsterstr. 57"
			dataRow("City") = "Mannheim"
			dataRow("Region") = ""
			dataRow("PostalCode") = "68306"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0621-08460"
			dataRow("Fax") = "0621-08924"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BLONP"
			dataRow("CompanyName") = "Blondel père et fils"
			dataRow("ContactName") = "Frédérique Citeaux"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "24, place Kléber"
			dataRow("City") = "Strasbourg"
			dataRow("Region") = ""
			dataRow("PostalCode") = "67000"
			dataRow("Country") = "France"
			dataRow("Phone") = "88.60.15.31"
			dataRow("Fax") = "88.60.15.32"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BOLID"
			dataRow("CompanyName") = "Bólido Comidas preparadas"
			dataRow("ContactName") = "Martín Sommer"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "C/ Araquil, 67"
			dataRow("City") = "Madrid"
			dataRow("Region") = ""
			dataRow("PostalCode") = "28023"
			dataRow("Country") = "Spain"
			dataRow("Phone") = "(91) 555 22 82"
			dataRow("Fax") = "(91) 555 91 99"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BONAP"
			dataRow("CompanyName") = "Bon app'"
			dataRow("ContactName") = "Laurence Lebihan"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "12, rue des Bouchers"
			dataRow("City") = "Marseille"
			dataRow("Region") = ""
			dataRow("PostalCode") = "13008"
			dataRow("Country") = "France"
			dataRow("Phone") = "91.24.45.40"
			dataRow("Fax") = "91.24.45.41"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BOTTM"
			dataRow("CompanyName") = "Bottom-Dollar Markets"
			dataRow("ContactName") = "Elizabeth Lincoln"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "23 Tsawassen Blvd."
			dataRow("City") = "Tsawwassen"
			dataRow("Region") = "BC"
			dataRow("PostalCode") = "T2F 8M4"
			dataRow("Country") = "Canada"
			dataRow("Phone") = "(604) 555-4729"
			dataRow("Fax") = "(604) 555-3745"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "BSBEV"
			dataRow("CompanyName") = "B's Beverages"
			dataRow("ContactName") = "Victoria Ashworth"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Fauntleroy Circus"
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "EC2 5NT"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-1212"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "CACTU"
			dataRow("CompanyName") = "Cactus Comidas para llevar"
			dataRow("ContactName") = "Patricio Simpson"
			dataRow("ContactTitle") = "Sales Agent"
			dataRow("Address") = "Cerrito 333"
			dataRow("City") = "Buenos Aires"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1010"
			dataRow("Country") = "Argentina"
			dataRow("Phone") = "(1) 135-5555"
			dataRow("Fax") = "(1) 135-4892"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "CENTC"
			dataRow("CompanyName") = "Centro comercial Moctezuma"
			dataRow("ContactName") = "Francisco Chang"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Sierras de Granada 9993"
			dataRow("City") = "México D.F."
			dataRow("Region") = ""
			dataRow("PostalCode") = "05022"
			dataRow("Country") = "Mexico"
			dataRow("Phone") = "(5) 555-3392"
			dataRow("Fax") = "(5) 555-7293"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "CHOPS"
			dataRow("CompanyName") = "Chop-suey Chinese"
			dataRow("ContactName") = "Yang Wang"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Hauptstr. 29"
			dataRow("City") = "Bern"
			dataRow("Region") = ""
			dataRow("PostalCode") = "3012"
			dataRow("Country") = "Switzerland"
			dataRow("Phone") = "0452-076545"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "COMMI"
			dataRow("CompanyName") = "Comércio Mineiro"
			dataRow("ContactName") = "Pedro Afonso"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "Av. dos Lusíadas, 23"
			dataRow("City") = "São Paulo"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "05432-043"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(11) 555-7647"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "CONSH"
			dataRow("CompanyName") = "Consolidated Holdings"
			dataRow("ContactName") = "Elizabeth Brown"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Berkeley Gardens 12  Brewery "
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "WX1 6LT"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-2282"
			dataRow("Fax") = "(171) 555-9199"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "DRACD"
			dataRow("CompanyName") = "Drachenblut Delikatessen"
			dataRow("ContactName") = "Sven Ottlieb"
			dataRow("ContactTitle") = "Order Administrator"
			dataRow("Address") = "Walserweg 21"
			dataRow("City") = "Aachen"
			dataRow("Region") = ""
			dataRow("PostalCode") = "52066"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0241-039123"
			dataRow("Fax") = "0241-059428"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "DUMON"
			dataRow("CompanyName") = "Du monde entier"
			dataRow("ContactName") = "Janine Labrune"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "67, rue des Cinquante Otages"
			dataRow("City") = "Nantes"
			dataRow("Region") = ""
			dataRow("PostalCode") = "44000"
			dataRow("Country") = "France"
			dataRow("Phone") = "40.67.88.88"
			dataRow("Fax") = "40.67.89.89"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "EASTC"
			dataRow("CompanyName") = "Eastern Connection"
			dataRow("ContactName") = "Ann Devon"
			dataRow("ContactTitle") = "Sales Agent"
			dataRow("Address") = "35 King George"
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "WX3 6FW"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-0297"
			dataRow("Fax") = "(171) 555-3373"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "ERNSH"
			dataRow("CompanyName") = "Ernst Handel"
			dataRow("ContactName") = "Roland Mendel"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Kirchgasse 6"
			dataRow("City") = "Graz"
			dataRow("Region") = ""
			dataRow("PostalCode") = "8010"
			dataRow("Country") = "Austria"
			dataRow("Phone") = "7675-3425"
			dataRow("Fax") = "7675-3426"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FAMIA"
			dataRow("CompanyName") = "Familia Arquibaldo"
			dataRow("ContactName") = "Aria Cruz"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "Rua Orós, 92"
			dataRow("City") = "São Paulo"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "05442-030"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(11) 555-9857"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FISSA"
			dataRow("CompanyName") = "FISSA Fabrica Inter. Salchichas S.A."
			dataRow("ContactName") = "Diego Roel"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "C/ Moralzarzal, 86"
			dataRow("City") = "Madrid"
			dataRow("Region") = ""
			dataRow("PostalCode") = "28034"
			dataRow("Country") = "Spain"
			dataRow("Phone") = "(91) 555 94 44"
			dataRow("Fax") = "(91) 555 55 93"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FOLIG"
			dataRow("CompanyName") = "Folies gourmandes"
			dataRow("ContactName") = "Martine Rancé"
			dataRow("ContactTitle") = "Assistant Sales Agent"
			dataRow("Address") = "184, chaussée de Tournai"
			dataRow("City") = "Lille"
			dataRow("Region") = ""
			dataRow("PostalCode") = "59000"
			dataRow("Country") = "France"
			dataRow("Phone") = "20.16.10.16"
			dataRow("Fax") = "20.16.10.17"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FOLKO"
			dataRow("CompanyName") = "Folk och fä HB"
			dataRow("ContactName") = "Maria Larsson"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Åkergatan 24"
			dataRow("City") = "Bräcke"
			dataRow("Region") = ""
			dataRow("PostalCode") = "S-844 67"
			dataRow("Country") = "Sweden"
			dataRow("Phone") = "0695-34 67 21"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FRANK"
			dataRow("CompanyName") = "Frankenversand"
			dataRow("ContactName") = "Peter Franken"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Berliner Platz 43"
			dataRow("City") = "München"
			dataRow("Region") = ""
			dataRow("PostalCode") = "80805"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "089-0877310"
			dataRow("Fax") = "089-0877451"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FRANR"
			dataRow("CompanyName") = "France restauration"
			dataRow("ContactName") = "Carine Schmitt"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "54, rue Royale"
			dataRow("City") = "Nantes"
			dataRow("Region") = ""
			dataRow("PostalCode") = "44000"
			dataRow("Country") = "France"
			dataRow("Phone") = "40.32.21.21"
			dataRow("Fax") = "40.32.21.20"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FRANS"
			dataRow("CompanyName") = "Franchi S.p.A."
			dataRow("ContactName") = "Paolo Accorti"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Via Monte Bianco 34"
			dataRow("City") = "Torino"
			dataRow("Region") = ""
			dataRow("PostalCode") = "10100"
			dataRow("Country") = "Italy"
			dataRow("Phone") = "011-4988260"
			dataRow("Fax") = "011-4988261"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "FURIB"
			dataRow("CompanyName") = "Furia Bacalhau e Frutos do Mar"
			dataRow("ContactName") = "Lino Rodriguez "
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Jardim das rosas n. 32"
			dataRow("City") = "Lisboa"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1675"
			dataRow("Country") = "Portugal"
			dataRow("Phone") = "(1) 354-2534"
			dataRow("Fax") = "(1) 354-2535"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "GALED"
			dataRow("CompanyName") = "Galería del gastrónomo"
			dataRow("ContactName") = "Eduardo Saavedra"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Rambla de Cataluña, 23"
			dataRow("City") = "Barcelona"
			dataRow("Region") = ""
			dataRow("PostalCode") = "08022"
			dataRow("Country") = "Spain"
			dataRow("Phone") = "(93) 203 4560"
			dataRow("Fax") = "(93) 203 4561"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "GODOS"
			dataRow("CompanyName") = "Godos Cocina Típica"
			dataRow("ContactName") = "José Pedro Freyre"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "C/ Romero, 33"
			dataRow("City") = "Sevilla"
			dataRow("Region") = ""
			dataRow("PostalCode") = "41101"
			dataRow("Country") = "Spain"
			dataRow("Phone") = "(95) 555 82 82"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "GOURL"
			dataRow("CompanyName") = "Gourmet Lanchonetes"
			dataRow("ContactName") = "André Fonseca"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "Av. Brasil, 442"
			dataRow("City") = "Campinas"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "04876-786"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(11) 555-9482"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "GREAL"
			dataRow("CompanyName") = "Great Lakes Food Market"
			dataRow("ContactName") = "Howard Snyder"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "2732 Baker Blvd."
			dataRow("City") = "Eugene"
			dataRow("Region") = "OR"
			dataRow("PostalCode") = "97403"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(503) 555-7555"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "GROSR"
			dataRow("CompanyName") = "GROSELLA-Restaurante"
			dataRow("ContactName") = "Manuel Pereira"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "5ª Ave. Los Palos Grandes"
			dataRow("City") = "Caracas"
			dataRow("Region") = "DF"
			dataRow("PostalCode") = "1081"
			dataRow("Country") = "Venezuela"
			dataRow("Phone") = "(2) 283-2951"
			dataRow("Fax") = "(2) 283-3397"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "HANAR"
			dataRow("CompanyName") = "Hanari Carnes"
			dataRow("ContactName") = "Mario Pontes"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Rua do Paço, 67"
			dataRow("City") = "Rio de Janeiro"
			dataRow("Region") = "RJ"
			dataRow("PostalCode") = "05454-876"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(21) 555-0091"
			dataRow("Fax") = "(21) 555-8765"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "HILAA"
			dataRow("CompanyName") = "HILARIÓN-Abastos"
			dataRow("ContactName") = "Carlos Hernández"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Carrera 22 con Ave. Carlos Soublette #8-35"
			dataRow("City") = "San Cristóbal"
			dataRow("Region") = "Táchira"
			dataRow("PostalCode") = "5022"
			dataRow("Country") = "Venezuela"
			dataRow("Phone") = "(5) 555-1340"
			dataRow("Fax") = "(5) 555-1948"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "HUNGC"
			dataRow("CompanyName") = "Hungry Coyote Import Store"
			dataRow("ContactName") = "Yoshi Latimer"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "City Center Plaza 516 Main St."
			dataRow("City") = "Elgin"
			dataRow("Region") = "OR"
			dataRow("PostalCode") = "97827"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(503) 555-6874"
			dataRow("Fax") = "(503) 555-2376"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "HUNGO"
			dataRow("CompanyName") = "Hungry Owl All-Night Grocers"
			dataRow("ContactName") = "Patricia McKenna"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "8 Johnstown Road"
			dataRow("City") = "Cork"
			dataRow("Region") = "Co. Cork"
			dataRow("PostalCode") = ""
			dataRow("Country") = "Ireland"
			dataRow("Phone") = "2967 542"
			dataRow("Fax") = "2967 3333"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "ISLAT"
			dataRow("CompanyName") = "Island Trading"
			dataRow("ContactName") = "Helen Bennett"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Garden HouseCrowther Way"
			dataRow("City") = "Cowes"
			dataRow("Region") = "Isle of Wight"
			dataRow("PostalCode") = "PO31 7PJ"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(198) 555-8888"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "KOENE"
			dataRow("CompanyName") = "Königlich Essen"
			dataRow("ContactName") = "Philip Cramer"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "Maubelstr. 90"
			dataRow("City") = "Brandenburg"
			dataRow("Region") = ""
			dataRow("PostalCode") = "14776"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0555-09876"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LACOR"
			dataRow("CompanyName") = "La corne d'abondance"
			dataRow("ContactName") = "Daniel Tonini"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "67, avenue de l'Europe"
			dataRow("City") = "Versailles"
			dataRow("Region") = ""
			dataRow("PostalCode") = "78000"
			dataRow("Country") = "France"
			dataRow("Phone") = "30.59.84.10"
			dataRow("Fax") = "30.59.85.11"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LAMAI"
			dataRow("CompanyName") = "La maison d'Asie"
			dataRow("ContactName") = "Annette Roulet"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "1 rue Alsace-Lorraine"
			dataRow("City") = "Toulouse"
			dataRow("Region") = ""
			dataRow("PostalCode") = "31000"
			dataRow("Country") = "France"
			dataRow("Phone") = "61.77.61.10"
			dataRow("Fax") = "61.77.61.11"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LAUGB"
			dataRow("CompanyName") = "Laughing Bacchus Wine Cellars"
			dataRow("ContactName") = "Yoshi Tannamuri"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "1900 Oak St."
			dataRow("City") = "Vancouver"
			dataRow("Region") = "BC"
			dataRow("PostalCode") = "V3F 2K1"
			dataRow("Country") = "Canada"
			dataRow("Phone") = "(604) 555-3392"
			dataRow("Fax") = "(604) 555-7293"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LAZYK"
			dataRow("CompanyName") = "Lazy K Kountry Store"
			dataRow("ContactName") = "John Steel"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "12 Orchestra Terrace"
			dataRow("City") = "Walla Walla"
			dataRow("Region") = "WA"
			dataRow("PostalCode") = "99362"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(509) 555-7969"
			dataRow("Fax") = "(509) 555-6221"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LEHMS"
			dataRow("CompanyName") = "Lehmanns Marktstand"
			dataRow("ContactName") = "Renate Messner"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Magazinweg 7"
			dataRow("City") = "Frankfurt a.M. "
			dataRow("Region") = ""
			dataRow("PostalCode") = "60528"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "069-0245984"
			dataRow("Fax") = "069-0245874"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LETSS"
			dataRow("CompanyName") = "Let's Stop N Shop"
			dataRow("ContactName") = "Jaime Yorres"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "87 Polk St.Suite 5"
			dataRow("City") = "San Francisco"
			dataRow("Region") = "CA"
			dataRow("PostalCode") = "94117"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(415) 555-5938"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LILAS"
			dataRow("CompanyName") = "LILA-Supermercado"
			dataRow("ContactName") = "Carlos González"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"
			dataRow("City") = "Barquisimeto"
			dataRow("Region") = "Lara"
			dataRow("PostalCode") = "3508"
			dataRow("Country") = "Venezuela"
			dataRow("Phone") = "(9) 331-6954"
			dataRow("Fax") = "(9) 331-7256"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LINOD"
			dataRow("CompanyName") = "LINO-Delicateses"
			dataRow("ContactName") = "Felipe Izquierdo"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Ave. 5 de Mayo Porlamar"
			dataRow("City") = "I. de Margarita"
			dataRow("Region") = "Nueva Esparta"
			dataRow("PostalCode") = "4980"
			dataRow("Country") = "Venezuela"
			dataRow("Phone") = "(8) 34-56-12"
			dataRow("Fax") = "(8) 34-93-93"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "LONEP"
			dataRow("CompanyName") = "Lonesome Pine Restaurant"
			dataRow("ContactName") = "Fran Wilson"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "89 Chiaroscuro Rd."
			dataRow("City") = "Portland"
			dataRow("Region") = "OR"
			dataRow("PostalCode") = "97219"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(503) 555-9573"
			dataRow("Fax") = "(503) 555-9646"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "MAGAA"
			dataRow("CompanyName") = "Magazzini Alimentari Riuniti"
			dataRow("ContactName") = "Giovanni Rovelli"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Via Ludovico il Moro 22"
			dataRow("City") = "Bergamo"
			dataRow("Region") = ""
			dataRow("PostalCode") = "24100"
			dataRow("Country") = "Italy"
			dataRow("Phone") = "035-640230"
			dataRow("Fax") = "035-640231"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "MAISD"
			dataRow("CompanyName") = "Maison Dewey"
			dataRow("ContactName") = "Catherine Dewey"
			dataRow("ContactTitle") = "Sales Agent"
			dataRow("Address") = "Rue Joseph-Bens 532"
			dataRow("City") = "Bruxelles"
			dataRow("Region") = ""
			dataRow("PostalCode") = "B-1180"
			dataRow("Country") = "Belgium"
			dataRow("Phone") = "(02) 201 24 67"
			dataRow("Fax") = "(02) 201 24 68"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "MEREP"
			dataRow("CompanyName") = "Mère Paillarde"
			dataRow("ContactName") = "Jean Fresnière"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "43 rue St. Laurent"
			dataRow("City") = "Montréal"
			dataRow("Region") = "Québec"
			dataRow("PostalCode") = "H1J 1C3"
			dataRow("Country") = "Canada"
			dataRow("Phone") = "(514) 555-8054"
			dataRow("Fax") = "(514) 555-8055"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "MORGK"
			dataRow("CompanyName") = "Morgenstern Gesundkost"
			dataRow("ContactName") = "Alexander Feuer"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "Heerstr. 22"
			dataRow("City") = "Leipzig"
			dataRow("Region") = ""
			dataRow("PostalCode") = "04179"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0342-023176"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "NORTS"
			dataRow("CompanyName") = "North/South"
			dataRow("ContactName") = "Simon Crowther"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "South House300 Queensbridge"
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "SW7 1RZ"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-7733"
			dataRow("Fax") = "(171) 555-2530"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "OCEAN"
			dataRow("CompanyName") = "Océano Atlántico Ltda."
			dataRow("ContactName") = "Yvonne Moncada"
			dataRow("ContactTitle") = "Sales Agent"
			dataRow("Address") = "Ing. Gustavo Moncada 8585Piso 20 - A"
			dataRow("City") = "Buenos Aires"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1010"
			dataRow("Country") = "Argentina"
			dataRow("Phone") = "(1) 135-5333"
			dataRow("Fax") = "(1) 135-5535"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "OLDWO"
			dataRow("CompanyName") = "Old World Delicatessen"
			dataRow("ContactName") = "Rene Phillips"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "2743 Bering St."
			dataRow("City") = "Anchorage"
			dataRow("Region") = "AK"
			dataRow("PostalCode") = "99508"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(907) 555-7584"
			dataRow("Fax") = "(907) 555-2880"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "OTTIK"
			dataRow("CompanyName") = "Ottilies Käseladen"
			dataRow("ContactName") = "Henriette Pfalzheim"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Mehrheimerstr. 369"
			dataRow("City") = "Köln"
			dataRow("Region") = ""
			dataRow("PostalCode") = "50739"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0221-0644327"
			dataRow("Fax") = "0221-0765721"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "PARIS"
			dataRow("CompanyName") = "Paris spécialités"
			dataRow("ContactName") = "Marie Bertrand"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "265, boulevard Charonne"
			dataRow("City") = "Paris"
			dataRow("Region") = ""
			dataRow("PostalCode") = "75012"
			dataRow("Country") = "France"
			dataRow("Phone") = "(1) 42.34.22.66"
			dataRow("Fax") = "(1) 42.34.22.77"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "PERIC"
			dataRow("CompanyName") = "Pericles Comidas clásicas"
			dataRow("ContactName") = "Guillermo Fernández"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Calle Dr. Jorge Cash 321"
			dataRow("City") = "México D.F."
			dataRow("Region") = ""
			dataRow("PostalCode") = "05033"
			dataRow("Country") = "Mexico"
			dataRow("Phone") = "(5) 552-3745"
			dataRow("Fax") = "(5) 545-3745"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "PICCO"
			dataRow("CompanyName") = "Piccolo und mehr"
			dataRow("ContactName") = "Georg Pipps"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Geislweg 14"
			dataRow("City") = "Salzburg"
			dataRow("Region") = ""
			dataRow("PostalCode") = "5020"
			dataRow("Country") = "Austria"
			dataRow("Phone") = "6562-9722"
			dataRow("Fax") = "6562-9723"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "PRINI"
			dataRow("CompanyName") = "Princesa Isabel Vinhos"
			dataRow("ContactName") = "Isabel de Castro"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Estrada da saúde n. 58"
			dataRow("City") = "Lisboa"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1756"
			dataRow("Country") = "Portugal"
			dataRow("Phone") = "(1) 356-5634"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "QUEDE"
			dataRow("CompanyName") = "Que Delícia"
			dataRow("ContactName") = "Bernardo Batista"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Rua da Panificadora, 12"
			dataRow("City") = "Rio de Janeiro"
			dataRow("Region") = "RJ"
			dataRow("PostalCode") = "02389-673"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(21) 555-4252"
			dataRow("Fax") = "(21) 555-4545"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "QUEEN"
			dataRow("CompanyName") = "Queen Cozinha"
			dataRow("ContactName") = "Lúcia Carvalho"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "Alameda dos Canàrios, 891"
			dataRow("City") = "São Paulo"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "05487-020"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(11) 555-1189"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "QUICK"
			dataRow("CompanyName") = "QUICK-Stop"
			dataRow("ContactName") = "Horst Kloss"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Taucherstraße 10"
			dataRow("City") = "Cunewalde"
			dataRow("Region") = ""
			dataRow("PostalCode") = "01307"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0372-035188"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "RANCH"
			dataRow("CompanyName") = "Rancho grande"
			dataRow("ContactName") = "Sergio Gutiérrez"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Av. del Libertador 900"
			dataRow("City") = "Buenos Aires"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1010"
			dataRow("Country") = "Argentina"
			dataRow("Phone") = "(1) 123-5555"
			dataRow("Fax") = "(1) 123-5556"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "RATTC"
			dataRow("CompanyName") = "Rattlesnake Canyon Grocery"
			dataRow("ContactName") = "Paula Wilson"
			dataRow("ContactTitle") = "Assistant Sales Representative"
			dataRow("Address") = "2817 Milton Dr."
			dataRow("City") = "Albuquerque"
			dataRow("Region") = "NM"
			dataRow("PostalCode") = "87110"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(505) 555-5939"
			dataRow("Fax") = "(505) 555-3620"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "REGGC"
			dataRow("CompanyName") = "Reggiani Caseifici"
			dataRow("ContactName") = "Maurizio Moroni"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "Strada Provinciale 124"
			dataRow("City") = "Reggio Emilia"
			dataRow("Region") = ""
			dataRow("PostalCode") = "42100"
			dataRow("Country") = "Italy"
			dataRow("Phone") = "0522-556721"
			dataRow("Fax") = "0522-556722"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "RICAR"
			dataRow("CompanyName") = "Ricardo Adocicados"
			dataRow("ContactName") = "Janete Limeira"
			dataRow("ContactTitle") = "Assistant Sales Agent"
			dataRow("Address") = "Av. Copacabana, 267"
			dataRow("City") = "Rio de Janeiro"
			dataRow("Region") = "RJ"
			dataRow("PostalCode") = "02389-890"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(21) 555-3412"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "RICSU"
			dataRow("CompanyName") = "Richter Supermarkt"
			dataRow("ContactName") = "Michael Holz"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Grenzacherweg 237"
			dataRow("City") = "Genève"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1203"
			dataRow("Country") = "Switzerland"
			dataRow("Phone") = "0897-034214"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "ROMEY"
			dataRow("CompanyName") = "Romero y tomillo"
			dataRow("ContactName") = "Alejandra Camino"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Gran Vía, 1"
			dataRow("City") = "Madrid"
			dataRow("Region") = ""
			dataRow("PostalCode") = "28001"
			dataRow("Country") = "Spain"
			dataRow("Phone") = "(91) 745 6200"
			dataRow("Fax") = "(91) 745 6210"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SANTG"
			dataRow("CompanyName") = "Santé Gourmet"
			dataRow("ContactName") = "Jonas Bergulfsen"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Erling Skakkes gate 78"
			dataRow("City") = "Stavern"
			dataRow("Region") = ""
			dataRow("PostalCode") = "4110"
			dataRow("Country") = "Norway"
			dataRow("Phone") = "07-98 92 35"
			dataRow("Fax") = "07-98 92 47"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SAVEA"
			dataRow("CompanyName") = "Save-a-lot Markets"
			dataRow("ContactName") = "Jose Pavarotti"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "187 Suffolk Ln."
			dataRow("City") = "Boise"
			dataRow("Region") = "ID"
			dataRow("PostalCode") = "83720"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(208) 555-8097"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SEVES"
			dataRow("CompanyName") = "Seven Seas Imports"
			dataRow("ContactName") = "Hari Kumar"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "90 Wadhurst Rd."
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "OX15 4NB"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-1717"
			dataRow("Fax") = "(171) 555-5646"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SIMOB"
			dataRow("CompanyName") = "Simons bistro"
			dataRow("ContactName") = "Jytte Petersen"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Vinbæltet 34"
			dataRow("City") = "København"
			dataRow("Region") = ""
			dataRow("PostalCode") = "1734"
			dataRow("Country") = "Denmark"
			dataRow("Phone") = "31 12 34 56"
			dataRow("Fax") = "31 13 35 57"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SPECD"
			dataRow("CompanyName") = "Spécialités du monde"
			dataRow("ContactName") = "Dominique Perrier"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "25, rue Lauriston"
			dataRow("City") = "Paris"
			dataRow("Region") = ""
			dataRow("PostalCode") = "75016"
			dataRow("Country") = "France"
			dataRow("Phone") = "(1) 47.55.60.10"
			dataRow("Fax") = "(1) 47.55.60.20"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SPLIR"
			dataRow("CompanyName") = "Split Rail Beer & Ale"
			dataRow("ContactName") = "Art Braunschweiger"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "P.O. Box 555"
			dataRow("City") = "Lander"
			dataRow("Region") = "WY"
			dataRow("PostalCode") = "82520"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(307) 555-4680"
			dataRow("Fax") = "(307) 555-6525"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "SUPRD"
			dataRow("CompanyName") = "Suprêmes délices"
			dataRow("ContactName") = "Pascale Cartrain"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Boulevard Tirou, 255"
			dataRow("City") = "Charleroi"
			dataRow("Region") = ""
			dataRow("PostalCode") = "B-6000"
			dataRow("Country") = "Belgium"
			dataRow("Phone") = "(071) 23 67 22 20"
			dataRow("Fax") = "(071) 23 67 22 21"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "THEBI"
			dataRow("CompanyName") = "The Big Cheese"
			dataRow("ContactName") = "Liz Nixon"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "89 Jefferson WaySuite 2"
			dataRow("City") = "Portland"
			dataRow("Region") = "OR"
			dataRow("PostalCode") = "97201"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(503) 555-3612"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "THECR"
			dataRow("CompanyName") = "The Cracker Box"
			dataRow("ContactName") = "Liu Wong"
			dataRow("ContactTitle") = "Marketing Assistant"
			dataRow("Address") = "55 Grizzly Peak Rd."
			dataRow("City") = "Butte"
			dataRow("Region") = "MT"
			dataRow("PostalCode") = "59801"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(406) 555-5834"
			dataRow("Fax") = "(406) 555-8083"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "TOMSP"
			dataRow("CompanyName") = "Toms Spezialitäten"
			dataRow("ContactName") = "Karin Josephs"
			dataRow("ContactTitle") = "Marketing Manager"
			dataRow("Address") = "Luisenstr. 48"
			dataRow("City") = "Münster"
			dataRow("Region") = ""
			dataRow("PostalCode") = "44087"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0251-031259"
			dataRow("Fax") = "0251-035695"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "TORTU"
			dataRow("CompanyName") = "Tortuga Restaurante"
			dataRow("ContactName") = "Miguel Angel Paolino"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "Avda. Azteca 123"
			dataRow("City") = "México D.F."
			dataRow("Region") = ""
			dataRow("PostalCode") = "05033"
			dataRow("Country") = "Mexico"
			dataRow("Phone") = "(5) 555-2933"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "TRADH"
			dataRow("CompanyName") = "Tradição Hipermercados"
			dataRow("ContactName") = "Anabela Domingues"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Av. Inês de Castro, 414"
			dataRow("City") = "São Paulo"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "05634-030"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(11) 555-2167"
			dataRow("Fax") = "(11) 555-2168"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "TRAIH"
			dataRow("CompanyName") = "Trail's Head Gourmet Provisioners"
			dataRow("ContactName") = "Helvetius Nagy"
			dataRow("ContactTitle") = "Sales Associate"
			dataRow("Address") = "722 DaVinci Blvd."
			dataRow("City") = "Kirkland"
			dataRow("Region") = "WA"
			dataRow("PostalCode") = "98034"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(206) 555-8257"
			dataRow("Fax") = "(206) 555-2174"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "VAFFE"
			dataRow("CompanyName") = "Vaffeljernet"
			dataRow("ContactName") = "Palle Ibsen"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Smagsløget 45"
			dataRow("City") = "Århus"
			dataRow("Region") = ""
			dataRow("PostalCode") = "8200"
			dataRow("Country") = "Denmark"
			dataRow("Phone") = "86 21 32 43"
			dataRow("Fax") = "86 22 33 44"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "VICTE"
			dataRow("CompanyName") = "Victuailles en stock"
			dataRow("ContactName") = "Mary Saveley"
			dataRow("ContactTitle") = "Sales Agent"
			dataRow("Address") = "2, rue du Commerce"
			dataRow("City") = "Lyon"
			dataRow("Region") = ""
			dataRow("PostalCode") = "69004"
			dataRow("Country") = "France"
			dataRow("Phone") = "78.32.54.86"
			dataRow("Fax") = "78.32.54.87"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "VINET"
			dataRow("CompanyName") = "Vins et alcools Chevalier"
			dataRow("ContactName") = "Paul Henriot"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "59 rue de l'Abbaye"
			dataRow("City") = "Reims"
			dataRow("Region") = ""
			dataRow("PostalCode") = "51100"
			dataRow("Country") = "France"
			dataRow("Phone") = "26.47.15.10"
			dataRow("Fax") = "26.47.15.11"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WANDK"
			dataRow("CompanyName") = "Die Wandernde Kuh"
			dataRow("ContactName") = "Rita Müller"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "Adenauerallee 900"
			dataRow("City") = "Stuttgart"
			dataRow("Region") = ""
			dataRow("PostalCode") = "70563"
			dataRow("Country") = "Germany"
			dataRow("Phone") = "0711-020361"
			dataRow("Fax") = "0711-035428"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WARTH"
			dataRow("CompanyName") = "Wartian Herkku"
			dataRow("ContactName") = "Pirkko Koskitalo"
			dataRow("ContactTitle") = "Accounting Manager"
			dataRow("Address") = "Torikatu 38"
			dataRow("City") = "Oulu"
			dataRow("Region") = ""
			dataRow("PostalCode") = "90110"
			dataRow("Country") = "Finland"
			dataRow("Phone") = "981-443655"
			dataRow("Fax") = "981-443655"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WELLI"
			dataRow("CompanyName") = "Wellington Importadora"
			dataRow("ContactName") = "Paula Parente"
			dataRow("ContactTitle") = "Sales Manager"
			dataRow("Address") = "Rua do Mercado, 12"
			dataRow("City") = "Resende"
			dataRow("Region") = "SP"
			dataRow("PostalCode") = "08737-363"
			dataRow("Country") = "Brazil"
			dataRow("Phone") = "(14) 555-8122"
			dataRow("Fax") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WHITC"
			dataRow("CompanyName") = "White Clover Markets"
			dataRow("ContactName") = "Karl Jablonski"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "305 - 14th Ave. S.Suite 3B"
			dataRow("City") = "Seattle"
			dataRow("Region") = "WA"
			dataRow("PostalCode") = "98128"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(206) 555-4112"
			dataRow("Fax") = "(206) 555-4115"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WILMK"
			dataRow("CompanyName") = "Wilman Kala"
			dataRow("ContactName") = "Matti Karttunen"
			dataRow("ContactTitle") = "Owner/Marketing Assistant"
			dataRow("Address") = "Keskuskatu 45"
			dataRow("City") = "Helsinki"
			dataRow("Region") = ""
			dataRow("PostalCode") = "21240"
			dataRow("Country") = "Finland"
			dataRow("Phone") = "90-224 8858"
			dataRow("Fax") = "90-224 8858"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("CustomerID") = "WOLZA"
			dataRow("CompanyName") = "Wolski  Zajazd"
			dataRow("ContactName") = "Zbyszek Piestrzeniewicz"
			dataRow("ContactTitle") = "Owner"
			dataRow("Address") = "ul. Filtrowa 68"
			dataRow("City") = "Warszawa"
			dataRow("Region") = ""
			dataRow("PostalCode") = "01-012"
			dataRow("Country") = "Poland"
			dataRow("Phone") = "(26) 642-7012"
			dataRow("Fax") = "(26) 642-7012"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Public Shared Function CreateChildTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow
			table.Columns.Add("OrderID", GetType(System.Int32))
			table.Columns.Add("CustomerID", GetType(System.String))
			table.Columns.Add("RequiredDate", GetType(DateTime))
			table.Columns.Add("Freight", GetType(System.Decimal))
			table.Columns.Add("ShipCity", GetType(System.String))
			dataRow = table.NewRow()
			dataRow("OrderID") = 10248
			dataRow("CustomerID") = "VINET"
			dataRow("RequiredDate") = DateTime.Parse("9/1/1994 12:00:00 AM")
			dataRow("Freight") = 32.38
			dataRow("ShipCity") = "Reims"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10249
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("9/16/1994 12:00:00 AM")
			dataRow("Freight") = 11.61
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10250
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("9/5/1994 12:00:00 AM")
			dataRow("Freight") = 65.83
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10251
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("9/5/1994 12:00:00 AM")
			dataRow("Freight") = 41.34
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10252
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("9/6/1994 12:00:00 AM")
			dataRow("Freight") = 51.3
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10253
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("8/24/1994 12:00:00 AM")
			dataRow("Freight") = 58.17
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10254
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("9/8/1994 12:00:00 AM")
			dataRow("Freight") = 22.98
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10255
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("9/9/1994 12:00:00 AM")
			dataRow("Freight") = 148.33
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10256
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("9/12/1994 12:00:00 AM")
			dataRow("Freight") = 13.97
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10257
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("9/13/1994 12:00:00 AM")
			dataRow("Freight") = 81.91
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10258
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("9/14/1994 12:00:00 AM")
			dataRow("Freight") = 140.51
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10259
			dataRow("CustomerID") = "CENTC"
			dataRow("RequiredDate") = DateTime.Parse("9/15/1994 12:00:00 AM")
			dataRow("Freight") = 3.25
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10260
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("9/16/1994 12:00:00 AM")
			dataRow("Freight") = 55.09
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10261
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("9/16/1994 12:00:00 AM")
			dataRow("Freight") = 3.05
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10262
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("9/19/1994 12:00:00 AM")
			dataRow("Freight") = 48.29
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10263
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("9/20/1994 12:00:00 AM")
			dataRow("Freight") = 146.06
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10264
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("9/21/1994 12:00:00 AM")
			dataRow("Freight") = 3.67
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10265
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("9/22/1994 12:00:00 AM")
			dataRow("Freight") = 55.28
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10266
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("10/7/1994 12:00:00 AM")
			dataRow("Freight") = 25.73
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10267
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("9/26/1994 12:00:00 AM")
			dataRow("Freight") = 208.58
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10268
			dataRow("CustomerID") = "GROSR"
			dataRow("RequiredDate") = DateTime.Parse("9/27/1994 12:00:00 AM")
			dataRow("Freight") = 66.29
			dataRow("ShipCity") = "Caracas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10269
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("9/14/1994 12:00:00 AM")
			dataRow("Freight") = 4.56
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10270
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("9/29/1994 12:00:00 AM")
			dataRow("Freight") = 136.54
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10271
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("9/29/1994 12:00:00 AM")
			dataRow("Freight") = 4.54
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10272
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("9/30/1994 12:00:00 AM")
			dataRow("Freight") = 98.03
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10273
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("10/3/1994 12:00:00 AM")
			dataRow("Freight") = 76.07
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10274
			dataRow("CustomerID") = "VINET"
			dataRow("RequiredDate") = DateTime.Parse("10/4/1994 12:00:00 AM")
			dataRow("Freight") = 6.01
			dataRow("ShipCity") = "Reims"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10275
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("10/5/1994 12:00:00 AM")
			dataRow("Freight") = 26.93
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10276
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("9/22/1994 12:00:00 AM")
			dataRow("Freight") = 13.84
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10277
			dataRow("CustomerID") = "MORGK"
			dataRow("RequiredDate") = DateTime.Parse("10/7/1994 12:00:00 AM")
			dataRow("Freight") = 125.77
			dataRow("ShipCity") = "Leipzig"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10278
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("10/10/1994 12:00:00 AM")
			dataRow("Freight") = 92.69
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10279
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("10/11/1994 12:00:00 AM")
			dataRow("Freight") = 25.83
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10280
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("10/12/1994 12:00:00 AM")
			dataRow("Freight") = 8.98
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10281
			dataRow("CustomerID") = "ROMEY"
			dataRow("RequiredDate") = DateTime.Parse("9/28/1994 12:00:00 AM")
			dataRow("Freight") = 2.94
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10282
			dataRow("CustomerID") = "ROMEY"
			dataRow("RequiredDate") = DateTime.Parse("10/13/1994 12:00:00 AM")
			dataRow("Freight") = 12.69
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10283
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("10/14/1994 12:00:00 AM")
			dataRow("Freight") = 84.81
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10284
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("10/17/1994 12:00:00 AM")
			dataRow("Freight") = 76.56
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10285
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("10/18/1994 12:00:00 AM")
			dataRow("Freight") = 76.83
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10286
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("10/19/1994 12:00:00 AM")
			dataRow("Freight") = 229.24
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10287
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("10/20/1994 12:00:00 AM")
			dataRow("Freight") = 12.76
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10288
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("10/21/1994 12:00:00 AM")
			dataRow("Freight") = 7.45
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10289
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("10/24/1994 12:00:00 AM")
			dataRow("Freight") = 22.77
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10290
			dataRow("CustomerID") = "COMMI"
			dataRow("RequiredDate") = DateTime.Parse("10/25/1994 12:00:00 AM")
			dataRow("Freight") = 79.7
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10291
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("10/25/1994 12:00:00 AM")
			dataRow("Freight") = 6.4
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10292
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("10/26/1994 12:00:00 AM")
			dataRow("Freight") = 1.35
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10293
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("10/27/1994 12:00:00 AM")
			dataRow("Freight") = 21.18
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10294
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("10/28/1994 12:00:00 AM")
			dataRow("Freight") = 147.26
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10295
			dataRow("CustomerID") = "VINET"
			dataRow("RequiredDate") = DateTime.Parse("10/31/1994 12:00:00 AM")
			dataRow("Freight") = 1.15
			dataRow("ShipCity") = "Reims"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10296
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("11/1/1994 12:00:00 AM")
			dataRow("Freight") = 0.12
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10297
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("11/16/1994 12:00:00 AM")
			dataRow("Freight") = 5.74
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10298
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/3/1994 12:00:00 AM")
			dataRow("Freight") = 168.22
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10299
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("11/4/1994 12:00:00 AM")
			dataRow("Freight") = 29.76
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10300
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("11/7/1994 12:00:00 AM")
			dataRow("Freight") = 17.68
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10301
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("11/7/1994 12:00:00 AM")
			dataRow("Freight") = 45.08
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10302
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("11/8/1994 12:00:00 AM")
			dataRow("Freight") = 6.27
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10303
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("11/9/1994 12:00:00 AM")
			dataRow("Freight") = 107.83
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10304
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("11/10/1994 12:00:00 AM")
			dataRow("Freight") = 63.79
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10305
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("11/11/1994 12:00:00 AM")
			dataRow("Freight") = 257.62
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10306
			dataRow("CustomerID") = "ROMEY"
			dataRow("RequiredDate") = DateTime.Parse("11/14/1994 12:00:00 AM")
			dataRow("Freight") = 7.56
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10307
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("11/15/1994 12:00:00 AM")
			dataRow("Freight") = 0.56
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10308
			dataRow("CustomerID") = "ANATR"
			dataRow("RequiredDate") = DateTime.Parse("11/16/1994 12:00:00 AM")
			dataRow("Freight") = 1.61
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10309
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/17/1994 12:00:00 AM")
			dataRow("Freight") = 47.3
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10310
			dataRow("CustomerID") = "THEBI"
			dataRow("RequiredDate") = DateTime.Parse("11/18/1994 12:00:00 AM")
			dataRow("Freight") = 17.52
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10311
			dataRow("CustomerID") = "DUMON"
			dataRow("RequiredDate") = DateTime.Parse("11/4/1994 12:00:00 AM")
			dataRow("Freight") = 24.69
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10312
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("11/21/1994 12:00:00 AM")
			dataRow("Freight") = 40.26
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10313
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("11/22/1994 12:00:00 AM")
			dataRow("Freight") = 1.96
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10314
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("11/23/1994 12:00:00 AM")
			dataRow("Freight") = 74.16
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10315
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("11/24/1994 12:00:00 AM")
			dataRow("Freight") = 41.76
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10316
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("11/25/1994 12:00:00 AM")
			dataRow("Freight") = 150.15
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10317
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("11/28/1994 12:00:00 AM")
			dataRow("Freight") = 12.69
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10318
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("11/29/1994 12:00:00 AM")
			dataRow("Freight") = 4.73
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10319
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("11/30/1994 12:00:00 AM")
			dataRow("Freight") = 64.5
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10320
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("11/17/1994 12:00:00 AM")
			dataRow("Freight") = 34.57
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10321
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("12/1/1994 12:00:00 AM")
			dataRow("Freight") = 3.43
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10322
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("12/2/1994 12:00:00 AM")
			dataRow("Freight") = 0.4
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10323
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("12/5/1994 12:00:00 AM")
			dataRow("Freight") = 4.88
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10324
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("12/6/1994 12:00:00 AM")
			dataRow("Freight") = 214.27
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10325
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("11/23/1994 12:00:00 AM")
			dataRow("Freight") = 64.86
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10326
			dataRow("CustomerID") = "BOLID"
			dataRow("RequiredDate") = DateTime.Parse("12/8/1994 12:00:00 AM")
			dataRow("Freight") = 77.92
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10327
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("12/9/1994 12:00:00 AM")
			dataRow("Freight") = 63.36
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10328
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("12/12/1994 12:00:00 AM")
			dataRow("Freight") = 87.03
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10329
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("12/27/1994 12:00:00 AM")
			dataRow("Freight") = 191.67
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10330
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("12/14/1994 12:00:00 AM")
			dataRow("Freight") = 12.75
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10331
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("12/28/1994 12:00:00 AM")
			dataRow("Freight") = 10.19
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10332
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("12/29/1994 12:00:00 AM")
			dataRow("Freight") = 52.84
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10333
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("12/16/1994 12:00:00 AM")
			dataRow("Freight") = 0.59
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10334
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("12/19/1994 12:00:00 AM")
			dataRow("Freight") = 8.56
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10335
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("12/20/1994 12:00:00 AM")
			dataRow("Freight") = 42.11
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10336
			dataRow("CustomerID") = "PRINI"
			dataRow("RequiredDate") = DateTime.Parse("12/21/1994 12:00:00 AM")
			dataRow("Freight") = 15.51
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10337
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("12/22/1994 12:00:00 AM")
			dataRow("Freight") = 108.26
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10338
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("12/23/1994 12:00:00 AM")
			dataRow("Freight") = 84.21
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10339
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("12/26/1994 12:00:00 AM")
			dataRow("Freight") = 15.66
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10340
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("12/27/1994 12:00:00 AM")
			dataRow("Freight") = 166.31
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10341
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("12/27/1994 12:00:00 AM")
			dataRow("Freight") = 26.78
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10342
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("12/14/1994 12:00:00 AM")
			dataRow("Freight") = 54.83
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10343
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("12/29/1994 12:00:00 AM")
			dataRow("Freight") = 110.37
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10344
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("12/30/1994 12:00:00 AM")
			dataRow("Freight") = 23.29
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10345
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("1/2/1995 12:00:00 AM")
			dataRow("Freight") = 249.06
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10346
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("1/17/1995 12:00:00 AM")
			dataRow("Freight") = 142.08
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10347
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("1/4/1995 12:00:00 AM")
			dataRow("Freight") = 3.1
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10348
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("1/5/1995 12:00:00 AM")
			dataRow("Freight") = 0.78
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10349
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("1/6/1995 12:00:00 AM")
			dataRow("Freight") = 8.63
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10350
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("1/9/1995 12:00:00 AM")
			dataRow("Freight") = 64.19
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10351
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("1/9/1995 12:00:00 AM")
			dataRow("Freight") = 162.33
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10352
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("12/27/1994 12:00:00 AM")
			dataRow("Freight") = 1.3
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10353
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("1/11/1995 12:00:00 AM")
			dataRow("Freight") = 360.63
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10354
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("1/12/1995 12:00:00 AM")
			dataRow("Freight") = 53.8
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10355
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("1/13/1995 12:00:00 AM")
			dataRow("Freight") = 41.95
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10356
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("1/16/1995 12:00:00 AM")
			dataRow("Freight") = 36.71
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10357
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("1/17/1995 12:00:00 AM")
			dataRow("Freight") = 34.88
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10358
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("1/18/1995 12:00:00 AM")
			dataRow("Freight") = 19.64
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10359
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("1/19/1995 12:00:00 AM")
			dataRow("Freight") = 288.43
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10360
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("1/20/1995 12:00:00 AM")
			dataRow("Freight") = 131.7
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10361
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("1/20/1995 12:00:00 AM")
			dataRow("Freight") = 183.17
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10362
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("1/23/1995 12:00:00 AM")
			dataRow("Freight") = 96.04
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10363
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("1/24/1995 12:00:00 AM")
			dataRow("Freight") = 30.54
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10364
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("2/7/1995 12:00:00 AM")
			dataRow("Freight") = 71.97
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10365
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("1/25/1995 12:00:00 AM")
			dataRow("Freight") = 22
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10366
			dataRow("CustomerID") = "GALED"
			dataRow("RequiredDate") = DateTime.Parse("2/9/1995 12:00:00 AM")
			dataRow("Freight") = 10.14
			dataRow("ShipCity") = "Barcelona"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10367
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("1/26/1995 12:00:00 AM")
			dataRow("Freight") = 13.55
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10368
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("1/27/1995 12:00:00 AM")
			dataRow("Freight") = 101.95
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10369
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("1/30/1995 12:00:00 AM")
			dataRow("Freight") = 195.68
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10370
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("1/31/1995 12:00:00 AM")
			dataRow("Freight") = 1.17
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10371
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("1/31/1995 12:00:00 AM")
			dataRow("Freight") = 0.45
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10372
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("2/1/1995 12:00:00 AM")
			dataRow("Freight") = 890.78
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10373
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("2/2/1995 12:00:00 AM")
			dataRow("Freight") = 124.12
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10374
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("2/2/1995 12:00:00 AM")
			dataRow("Freight") = 3.94
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10375
			dataRow("CustomerID") = "HUNGC"
			dataRow("RequiredDate") = DateTime.Parse("2/3/1995 12:00:00 AM")
			dataRow("Freight") = 20.12
			dataRow("ShipCity") = "Elgin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10376
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("2/6/1995 12:00:00 AM")
			dataRow("Freight") = 20.39
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10377
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("2/6/1995 12:00:00 AM")
			dataRow("Freight") = 22.21
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10378
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("2/7/1995 12:00:00 AM")
			dataRow("Freight") = 5.44
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10379
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("2/8/1995 12:00:00 AM")
			dataRow("Freight") = 45.03
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10380
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("2/9/1995 12:00:00 AM")
			dataRow("Freight") = 35.03
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10381
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("2/9/1995 12:00:00 AM")
			dataRow("Freight") = 7.99
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10382
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/10/1995 12:00:00 AM")
			dataRow("Freight") = 94.77
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10383
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("2/13/1995 12:00:00 AM")
			dataRow("Freight") = 34.24
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10384
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("2/13/1995 12:00:00 AM")
			dataRow("Freight") = 168.64
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10385
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("2/14/1995 12:00:00 AM")
			dataRow("Freight") = 30.96
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10386
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("2/1/1995 12:00:00 AM")
			dataRow("Freight") = 13.99
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10387
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("2/15/1995 12:00:00 AM")
			dataRow("Freight") = 93.63
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10388
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("2/16/1995 12:00:00 AM")
			dataRow("Freight") = 34.86
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10389
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("2/17/1995 12:00:00 AM")
			dataRow("Freight") = 47.42
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10390
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/20/1995 12:00:00 AM")
			dataRow("Freight") = 126.38
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10391
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("2/20/1995 12:00:00 AM")
			dataRow("Freight") = 5.45
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10392
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("2/21/1995 12:00:00 AM")
			dataRow("Freight") = 122.46
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10393
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("2/22/1995 12:00:00 AM")
			dataRow("Freight") = 126.56
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10394
			dataRow("CustomerID") = "HUNGC"
			dataRow("RequiredDate") = DateTime.Parse("2/22/1995 12:00:00 AM")
			dataRow("Freight") = 30.34
			dataRow("ShipCity") = "Elgin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10395
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("2/23/1995 12:00:00 AM")
			dataRow("Freight") = 184.41
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10396
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("2/10/1995 12:00:00 AM")
			dataRow("Freight") = 135.35
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10397
			dataRow("CustomerID") = "PRINI"
			dataRow("RequiredDate") = DateTime.Parse("2/24/1995 12:00:00 AM")
			dataRow("Freight") = 60.26
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10398
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("2/27/1995 12:00:00 AM")
			dataRow("Freight") = 89.16
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10399
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("2/14/1995 12:00:00 AM")
			dataRow("Freight") = 27.36
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10400
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("3/1/1995 12:00:00 AM")
			dataRow("Freight") = 83.93
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10401
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("3/1/1995 12:00:00 AM")
			dataRow("Freight") = 12.51
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10402
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("3/16/1995 12:00:00 AM")
			dataRow("Freight") = 67.88
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10403
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("3/3/1995 12:00:00 AM")
			dataRow("Freight") = 73.79
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10404
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("3/3/1995 12:00:00 AM")
			dataRow("Freight") = 155.97
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10405
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("3/6/1995 12:00:00 AM")
			dataRow("Freight") = 34.82
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10406
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("3/21/1995 12:00:00 AM")
			dataRow("Freight") = 108.04
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10407
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("3/7/1995 12:00:00 AM")
			dataRow("Freight") = 91.48
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10408
			dataRow("CustomerID") = "FOLIG"
			dataRow("RequiredDate") = DateTime.Parse("3/8/1995 12:00:00 AM")
			dataRow("Freight") = 11.26
			dataRow("ShipCity") = "Lille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10409
			dataRow("CustomerID") = "OCEAN"
			dataRow("RequiredDate") = DateTime.Parse("3/9/1995 12:00:00 AM")
			dataRow("Freight") = 29.83
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10410
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("3/10/1995 12:00:00 AM")
			dataRow("Freight") = 2.4
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10411
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("3/10/1995 12:00:00 AM")
			dataRow("Freight") = 23.65
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10412
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("3/13/1995 12:00:00 AM")
			dataRow("Freight") = 3.77
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10413
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("3/14/1995 12:00:00 AM")
			dataRow("Freight") = 95.66
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10414
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("3/14/1995 12:00:00 AM")
			dataRow("Freight") = 21.48
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10415
			dataRow("CustomerID") = "HUNGC"
			dataRow("RequiredDate") = DateTime.Parse("3/15/1995 12:00:00 AM")
			dataRow("Freight") = 0.2
			dataRow("ShipCity") = "Elgin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10416
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("3/16/1995 12:00:00 AM")
			dataRow("Freight") = 22.72
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10417
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("3/16/1995 12:00:00 AM")
			dataRow("Freight") = 70.29
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10418
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("3/17/1995 12:00:00 AM")
			dataRow("Freight") = 17.55
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10419
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("3/20/1995 12:00:00 AM")
			dataRow("Freight") = 137.35
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10420
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("3/21/1995 12:00:00 AM")
			dataRow("Freight") = 44.12
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10421
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("4/4/1995 12:00:00 AM")
			dataRow("Freight") = 99.23
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10422
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("3/22/1995 12:00:00 AM")
			dataRow("Freight") = 3.02
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10423
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("3/9/1995 12:00:00 AM")
			dataRow("Freight") = 24.5
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10424
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("3/23/1995 12:00:00 AM")
			dataRow("Freight") = 370.61
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10425
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("3/24/1995 12:00:00 AM")
			dataRow("Freight") = 7.93
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10426
			dataRow("CustomerID") = "GALED"
			dataRow("RequiredDate") = DateTime.Parse("3/27/1995 12:00:00 AM")
			dataRow("Freight") = 18.69
			dataRow("ShipCity") = "Barcelona"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10427
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("3/27/1995 12:00:00 AM")
			dataRow("Freight") = 31.29
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10428
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("3/28/1995 12:00:00 AM")
			dataRow("Freight") = 11.09
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10429
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1995 12:00:00 AM")
			dataRow("Freight") = 56.63
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10430
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("3/16/1995 12:00:00 AM")
			dataRow("Freight") = 458.78
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10431
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("3/16/1995 12:00:00 AM")
			dataRow("Freight") = 44.17
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10432
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("3/17/1995 12:00:00 AM")
			dataRow("Freight") = 4.34
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10433
			dataRow("CustomerID") = "PRINI"
			dataRow("RequiredDate") = DateTime.Parse("4/3/1995 12:00:00 AM")
			dataRow("Freight") = 73.83
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10434
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("4/3/1995 12:00:00 AM")
			dataRow("Freight") = 17.92
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10435
			dataRow("CustomerID") = "CONSH"
			dataRow("RequiredDate") = DateTime.Parse("4/18/1995 12:00:00 AM")
			dataRow("Freight") = 9.21
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10436
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1995 12:00:00 AM")
			dataRow("Freight") = 156.66
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10437
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1995 12:00:00 AM")
			dataRow("Freight") = 19.97
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10438
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("4/6/1995 12:00:00 AM")
			dataRow("Freight") = 8.24
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10439
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("4/7/1995 12:00:00 AM")
			dataRow("Freight") = 4.07
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10440
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("4/10/1995 12:00:00 AM")
			dataRow("Freight") = 86.53
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10441
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("4/24/1995 12:00:00 AM")
			dataRow("Freight") = 73.02
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10442
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("4/11/1995 12:00:00 AM")
			dataRow("Freight") = 47.94
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10443
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1995 12:00:00 AM")
			dataRow("Freight") = 13.95
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10444
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1995 12:00:00 AM")
			dataRow("Freight") = 3.5
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10445
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("4/13/1995 12:00:00 AM")
			dataRow("Freight") = 9.3
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10446
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("4/14/1995 12:00:00 AM")
			dataRow("Freight") = 14.68
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10447
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("4/14/1995 12:00:00 AM")
			dataRow("Freight") = 68.66
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10448
			dataRow("CustomerID") = "RANCH"
			dataRow("RequiredDate") = DateTime.Parse("4/17/1995 12:00:00 AM")
			dataRow("Freight") = 38.82
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10449
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("4/18/1995 12:00:00 AM")
			dataRow("Freight") = 53.3
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10450
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("4/19/1995 12:00:00 AM")
			dataRow("Freight") = 7.23
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10451
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1995 12:00:00 AM")
			dataRow("Freight") = 189.09
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10452
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("4/20/1995 12:00:00 AM")
			dataRow("Freight") = 140.26
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10453
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("4/21/1995 12:00:00 AM")
			dataRow("Freight") = 25.36
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10454
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("4/21/1995 12:00:00 AM")
			dataRow("Freight") = 2.74
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10455
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1995 12:00:00 AM")
			dataRow("Freight") = 180.45
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10456
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1995 12:00:00 AM")
			dataRow("Freight") = 8.12
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10457
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1995 12:00:00 AM")
			dataRow("Freight") = 11.57
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10458
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("4/26/1995 12:00:00 AM")
			dataRow("Freight") = 147.06
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10459
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("4/27/1995 12:00:00 AM")
			dataRow("Freight") = 25.09
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10460
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("4/28/1995 12:00:00 AM")
			dataRow("Freight") = 16.27
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10461
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("4/28/1995 12:00:00 AM")
			dataRow("Freight") = 148.61
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10462
			dataRow("CustomerID") = "CONSH"
			dataRow("RequiredDate") = DateTime.Parse("5/1/1995 12:00:00 AM")
			dataRow("Freight") = 6.17
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10463
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1995 12:00:00 AM")
			dataRow("Freight") = 14.78
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10464
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1995 12:00:00 AM")
			dataRow("Freight") = 89
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10465
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("5/3/1995 12:00:00 AM")
			dataRow("Freight") = 145.04
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10466
			dataRow("CustomerID") = "COMMI"
			dataRow("RequiredDate") = DateTime.Parse("5/4/1995 12:00:00 AM")
			dataRow("Freight") = 11.93
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10467
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("5/4/1995 12:00:00 AM")
			dataRow("Freight") = 4.93
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10468
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("5/5/1995 12:00:00 AM")
			dataRow("Freight") = 44.12
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10469
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1995 12:00:00 AM")
			dataRow("Freight") = 60.18
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10470
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1995 12:00:00 AM")
			dataRow("Freight") = 64.56
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10471
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1995 12:00:00 AM")
			dataRow("Freight") = 45.59
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10472
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("5/10/1995 12:00:00 AM")
			dataRow("Freight") = 4.2
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10473
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("4/27/1995 12:00:00 AM")
			dataRow("Freight") = 16.37
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10474
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("5/11/1995 12:00:00 AM")
			dataRow("Freight") = 83.49
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10475
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("5/12/1995 12:00:00 AM")
			dataRow("Freight") = 68.52
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10476
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("5/15/1995 12:00:00 AM")
			dataRow("Freight") = 4.41
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10477
			dataRow("CustomerID") = "PRINI"
			dataRow("RequiredDate") = DateTime.Parse("5/15/1995 12:00:00 AM")
			dataRow("Freight") = 13.02
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10478
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1995 12:00:00 AM")
			dataRow("Freight") = 4.81
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10479
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1995 12:00:00 AM")
			dataRow("Freight") = 708.95
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10480
			dataRow("CustomerID") = "FOLIG"
			dataRow("RequiredDate") = DateTime.Parse("5/18/1995 12:00:00 AM")
			dataRow("Freight") = 1.35
			dataRow("ShipCity") = "Lille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10481
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("5/18/1995 12:00:00 AM")
			dataRow("Freight") = 64.33
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10482
			dataRow("CustomerID") = "LAZYK"
			dataRow("RequiredDate") = DateTime.Parse("5/19/1995 12:00:00 AM")
			dataRow("Freight") = 7.48
			dataRow("ShipCity") = "Walla Walla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10483
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("5/22/1995 12:00:00 AM")
			dataRow("Freight") = 15.28
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10484
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("5/22/1995 12:00:00 AM")
			dataRow("Freight") = 6.88
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10485
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1995 12:00:00 AM")
			dataRow("Freight") = 64.45
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10486
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1995 12:00:00 AM")
			dataRow("Freight") = 30.53
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10487
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1995 12:00:00 AM")
			dataRow("Freight") = 71.07
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10488
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("5/25/1995 12:00:00 AM")
			dataRow("Freight") = 4.93
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10489
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("5/26/1995 12:00:00 AM")
			dataRow("Freight") = 5.29
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10490
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1995 12:00:00 AM")
			dataRow("Freight") = 210.19
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10491
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1995 12:00:00 AM")
			dataRow("Freight") = 16.96
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10492
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("5/30/1995 12:00:00 AM")
			dataRow("Freight") = 62.89
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10493
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("5/31/1995 12:00:00 AM")
			dataRow("Freight") = 10.64
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10494
			dataRow("CustomerID") = "COMMI"
			dataRow("RequiredDate") = DateTime.Parse("5/31/1995 12:00:00 AM")
			dataRow("Freight") = 65.99
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10495
			dataRow("CustomerID") = "LAUGB"
			dataRow("RequiredDate") = DateTime.Parse("6/1/1995 12:00:00 AM")
			dataRow("Freight") = 4.65
			dataRow("ShipCity") = "Vancouver"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10496
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("6/2/1995 12:00:00 AM")
			dataRow("Freight") = 46.77
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10497
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("6/2/1995 12:00:00 AM")
			dataRow("Freight") = 36.21
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10498
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1995 12:00:00 AM")
			dataRow("Freight") = 29.75
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10499
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("6/6/1995 12:00:00 AM")
			dataRow("Freight") = 102.02
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10500
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1995 12:00:00 AM")
			dataRow("Freight") = 42.68
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10501
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1995 12:00:00 AM")
			dataRow("Freight") = 8.85
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10502
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("6/8/1995 12:00:00 AM")
			dataRow("Freight") = 69.32
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10503
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("6/9/1995 12:00:00 AM")
			dataRow("Freight") = 16.74
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10504
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("6/9/1995 12:00:00 AM")
			dataRow("Freight") = 59.13
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10505
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("6/12/1995 12:00:00 AM")
			dataRow("Freight") = 7.13
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10506
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("6/13/1995 12:00:00 AM")
			dataRow("Freight") = 21.19
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10507
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("6/13/1995 12:00:00 AM")
			dataRow("Freight") = 47.45
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10508
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1995 12:00:00 AM")
			dataRow("Freight") = 4.99
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10509
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("6/15/1995 12:00:00 AM")
			dataRow("Freight") = 0.15
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10510
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("6/16/1995 12:00:00 AM")
			dataRow("Freight") = 367.63
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10511
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("6/16/1995 12:00:00 AM")
			dataRow("Freight") = 350.64
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10512
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("6/19/1995 12:00:00 AM")
			dataRow("Freight") = 3.53
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10513
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("7/4/1995 12:00:00 AM")
			dataRow("Freight") = 105.65
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10514
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("6/20/1995 12:00:00 AM")
			dataRow("Freight") = 789.95
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10515
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1995 12:00:00 AM")
			dataRow("Freight") = 204.47
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10516
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("6/22/1995 12:00:00 AM")
			dataRow("Freight") = 62.78
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10517
			dataRow("CustomerID") = "NORTS"
			dataRow("RequiredDate") = DateTime.Parse("6/22/1995 12:00:00 AM")
			dataRow("Freight") = 32.07
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10518
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("6/9/1995 12:00:00 AM")
			dataRow("Freight") = 218.15
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10519
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("6/26/1995 12:00:00 AM")
			dataRow("Freight") = 91.76
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10520
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("6/27/1995 12:00:00 AM")
			dataRow("Freight") = 13.37
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10521
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("6/27/1995 12:00:00 AM")
			dataRow("Freight") = 17.22
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10522
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("6/28/1995 12:00:00 AM")
			dataRow("Freight") = 45.33
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10523
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("6/29/1995 12:00:00 AM")
			dataRow("Freight") = 77.63
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10524
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("6/29/1995 12:00:00 AM")
			dataRow("Freight") = 244.79
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10525
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("6/30/1995 12:00:00 AM")
			dataRow("Freight") = 11.06
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10526
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1995 12:00:00 AM")
			dataRow("Freight") = 58.59
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10527
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1995 12:00:00 AM")
			dataRow("Freight") = 41.9
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10528
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("6/20/1995 12:00:00 AM")
			dataRow("Freight") = 3.35
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10529
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("7/5/1995 12:00:00 AM")
			dataRow("Freight") = 66.69
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10530
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("7/6/1995 12:00:00 AM")
			dataRow("Freight") = 339.22
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10531
			dataRow("CustomerID") = "OCEAN"
			dataRow("RequiredDate") = DateTime.Parse("7/6/1995 12:00:00 AM")
			dataRow("Freight") = 8.12
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10532
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("7/7/1995 12:00:00 AM")
			dataRow("Freight") = 74.46
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10533
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("7/10/1995 12:00:00 AM")
			dataRow("Freight") = 188.04
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10534
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("7/10/1995 12:00:00 AM")
			dataRow("Freight") = 27.94
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10535
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("7/11/1995 12:00:00 AM")
			dataRow("Freight") = 15.64
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10536
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("7/12/1995 12:00:00 AM")
			dataRow("Freight") = 58.88
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10537
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("6/28/1995 12:00:00 AM")
			dataRow("Freight") = 78.85
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10538
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("7/13/1995 12:00:00 AM")
			dataRow("Freight") = 4.87
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10539
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("7/14/1995 12:00:00 AM")
			dataRow("Freight") = 12.36
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10540
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("7/17/1995 12:00:00 AM")
			dataRow("Freight") = 1007.64
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10541
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("7/17/1995 12:00:00 AM")
			dataRow("Freight") = 68.65
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10542
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("7/18/1995 12:00:00 AM")
			dataRow("Freight") = 10.95
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10543
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("7/19/1995 12:00:00 AM")
			dataRow("Freight") = 48.17
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10544
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("7/19/1995 12:00:00 AM")
			dataRow("Freight") = 24.91
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10545
			dataRow("CustomerID") = "LAZYK"
			dataRow("RequiredDate") = DateTime.Parse("7/20/1995 12:00:00 AM")
			dataRow("Freight") = 11.92
			dataRow("ShipCity") = "Walla Walla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10546
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("7/21/1995 12:00:00 AM")
			dataRow("Freight") = 194.72
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10547
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("7/21/1995 12:00:00 AM")
			dataRow("Freight") = 178.43
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10548
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("7/24/1995 12:00:00 AM")
			dataRow("Freight") = 1.43
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10549
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("7/11/1995 12:00:00 AM")
			dataRow("Freight") = 171.24
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10550
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("7/26/1995 12:00:00 AM")
			dataRow("Freight") = 4.32
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10551
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("8/9/1995 12:00:00 AM")
			dataRow("Freight") = 72.95
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10552
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("7/27/1995 12:00:00 AM")
			dataRow("Freight") = 83.22
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10553
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("7/28/1995 12:00:00 AM")
			dataRow("Freight") = 149.49
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10554
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("7/28/1995 12:00:00 AM")
			dataRow("Freight") = 120.97
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10555
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("7/31/1995 12:00:00 AM")
			dataRow("Freight") = 252.49
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10556
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("8/15/1995 12:00:00 AM")
			dataRow("Freight") = 9.8
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10557
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("7/18/1995 12:00:00 AM")
			dataRow("Freight") = 96.72
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10558
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("8/2/1995 12:00:00 AM")
			dataRow("Freight") = 72.97
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10559
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("8/3/1995 12:00:00 AM")
			dataRow("Freight") = 8.05
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10560
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("8/4/1995 12:00:00 AM")
			dataRow("Freight") = 36.65
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10561
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("8/4/1995 12:00:00 AM")
			dataRow("Freight") = 242.21
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10562
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("8/7/1995 12:00:00 AM")
			dataRow("Freight") = 22.95
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10563
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("8/22/1995 12:00:00 AM")
			dataRow("Freight") = 60.43
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10564
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("8/8/1995 12:00:00 AM")
			dataRow("Freight") = 13.75
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10565
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("8/9/1995 12:00:00 AM")
			dataRow("Freight") = 7.15
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10566
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("8/10/1995 12:00:00 AM")
			dataRow("Freight") = 88.4
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10567
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("8/10/1995 12:00:00 AM")
			dataRow("Freight") = 33.97
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10568
			dataRow("CustomerID") = "GALED"
			dataRow("RequiredDate") = DateTime.Parse("8/11/1995 12:00:00 AM")
			dataRow("Freight") = 6.54
			dataRow("ShipCity") = "Barcelona"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10569
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("8/14/1995 12:00:00 AM")
			dataRow("Freight") = 58.98
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10570
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("8/15/1995 12:00:00 AM")
			dataRow("Freight") = 188.99
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10571
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("8/29/1995 12:00:00 AM")
			dataRow("Freight") = 26.06
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10572
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("8/16/1995 12:00:00 AM")
			dataRow("Freight") = 116.43
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10573
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("8/17/1995 12:00:00 AM")
			dataRow("Freight") = 84.84
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10574
			dataRow("CustomerID") = "TRAIH"
			dataRow("RequiredDate") = DateTime.Parse("8/17/1995 12:00:00 AM")
			dataRow("Freight") = 37.6
			dataRow("ShipCity") = "Kirkland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10575
			dataRow("CustomerID") = "MORGK"
			dataRow("RequiredDate") = DateTime.Parse("8/4/1995 12:00:00 AM")
			dataRow("Freight") = 127.34
			dataRow("ShipCity") = "Leipzig"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10576
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("8/7/1995 12:00:00 AM")
			dataRow("Freight") = 18.56
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10577
			dataRow("CustomerID") = "TRAIH"
			dataRow("RequiredDate") = DateTime.Parse("9/4/1995 12:00:00 AM")
			dataRow("Freight") = 25.41
			dataRow("ShipCity") = "Kirkland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10578
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("8/22/1995 12:00:00 AM")
			dataRow("Freight") = 29.6
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10579
			dataRow("CustomerID") = "LETSS"
			dataRow("RequiredDate") = DateTime.Parse("8/23/1995 12:00:00 AM")
			dataRow("Freight") = 13.73
			dataRow("ShipCity") = "San Francisco"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10580
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("8/24/1995 12:00:00 AM")
			dataRow("Freight") = 75.89
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10581
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("8/24/1995 12:00:00 AM")
			dataRow("Freight") = 3.01
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10582
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("8/25/1995 12:00:00 AM")
			dataRow("Freight") = 27.71
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10583
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("8/28/1995 12:00:00 AM")
			dataRow("Freight") = 7.28
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10584
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("8/28/1995 12:00:00 AM")
			dataRow("Freight") = 59.14
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10585
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("8/29/1995 12:00:00 AM")
			dataRow("Freight") = 13.41
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10586
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("8/30/1995 12:00:00 AM")
			dataRow("Freight") = 0.48
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10587
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("8/30/1995 12:00:00 AM")
			dataRow("Freight") = 62.52
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10588
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("8/31/1995 12:00:00 AM")
			dataRow("Freight") = 194.67
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10589
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("9/1/1995 12:00:00 AM")
			dataRow("Freight") = 4.42
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10590
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("9/4/1995 12:00:00 AM")
			dataRow("Freight") = 44.77
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10591
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("8/21/1995 12:00:00 AM")
			dataRow("Freight") = 55.92
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10592
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("9/5/1995 12:00:00 AM")
			dataRow("Freight") = 32.1
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10593
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("9/6/1995 12:00:00 AM")
			dataRow("Freight") = 174.2
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10594
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("9/6/1995 12:00:00 AM")
			dataRow("Freight") = 5.24
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10595
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("9/7/1995 12:00:00 AM")
			dataRow("Freight") = 96.78
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10596
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("9/8/1995 12:00:00 AM")
			dataRow("Freight") = 16.34
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10597
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("9/8/1995 12:00:00 AM")
			dataRow("Freight") = 35.12
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10598
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("9/11/1995 12:00:00 AM")
			dataRow("Freight") = 44.42
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10599
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("9/26/1995 12:00:00 AM")
			dataRow("Freight") = 29.98
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10600
			dataRow("CustomerID") = "HUNGC"
			dataRow("RequiredDate") = DateTime.Parse("9/13/1995 12:00:00 AM")
			dataRow("Freight") = 45.13
			dataRow("ShipCity") = "Elgin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10601
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("9/27/1995 12:00:00 AM")
			dataRow("Freight") = 58.3
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10602
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("9/14/1995 12:00:00 AM")
			dataRow("Freight") = 2.92
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10603
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("9/15/1995 12:00:00 AM")
			dataRow("Freight") = 48.77
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10604
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("9/15/1995 12:00:00 AM")
			dataRow("Freight") = 7.46
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10605
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("9/18/1995 12:00:00 AM")
			dataRow("Freight") = 379.13
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10606
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("9/19/1995 12:00:00 AM")
			dataRow("Freight") = 79.4
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10607
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("9/19/1995 12:00:00 AM")
			dataRow("Freight") = 200.24
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10608
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("9/20/1995 12:00:00 AM")
			dataRow("Freight") = 27.79
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10609
			dataRow("CustomerID") = "DUMON"
			dataRow("RequiredDate") = DateTime.Parse("9/21/1995 12:00:00 AM")
			dataRow("Freight") = 1.85
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10610
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("9/22/1995 12:00:00 AM")
			dataRow("Freight") = 26.78
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10611
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("9/22/1995 12:00:00 AM")
			dataRow("Freight") = 80.65
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10612
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("9/25/1995 12:00:00 AM")
			dataRow("Freight") = 544.08
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10613
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("9/26/1995 12:00:00 AM")
			dataRow("Freight") = 8.11
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10614
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("9/26/1995 12:00:00 AM")
			dataRow("Freight") = 1.93
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10615
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("9/27/1995 12:00:00 AM")
			dataRow("Freight") = 0.75
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10616
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("9/28/1995 12:00:00 AM")
			dataRow("Freight") = 116.53
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10617
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("9/28/1995 12:00:00 AM")
			dataRow("Freight") = 18.53
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10618
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("10/13/1995 12:00:00 AM")
			dataRow("Freight") = 154.68
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10619
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("10/2/1995 12:00:00 AM")
			dataRow("Freight") = 91.05
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10620
			dataRow("CustomerID") = "LAUGB"
			dataRow("RequiredDate") = DateTime.Parse("10/3/1995 12:00:00 AM")
			dataRow("Freight") = 0.94
			dataRow("ShipCity") = "Vancouver"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10621
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("10/3/1995 12:00:00 AM")
			dataRow("Freight") = 23.73
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10622
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("10/4/1995 12:00:00 AM")
			dataRow("Freight") = 50.97
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10623
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("10/5/1995 12:00:00 AM")
			dataRow("Freight") = 97.18
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10624
			dataRow("CustomerID") = "THECR"
			dataRow("RequiredDate") = DateTime.Parse("10/5/1995 12:00:00 AM")
			dataRow("Freight") = 94.8
			dataRow("ShipCity") = "Butte"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10625
			dataRow("CustomerID") = "ANATR"
			dataRow("RequiredDate") = DateTime.Parse("10/6/1995 12:00:00 AM")
			dataRow("Freight") = 43.9
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10626
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("10/9/1995 12:00:00 AM")
			dataRow("Freight") = 138.69
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10627
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("10/23/1995 12:00:00 AM")
			dataRow("Freight") = 107.46
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10628
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("10/10/1995 12:00:00 AM")
			dataRow("Freight") = 30.36
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10629
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("10/10/1995 12:00:00 AM")
			dataRow("Freight") = 85.46
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10630
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("10/11/1995 12:00:00 AM")
			dataRow("Freight") = 32.35
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10631
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("10/12/1995 12:00:00 AM")
			dataRow("Freight") = 0.87
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10632
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("10/12/1995 12:00:00 AM")
			dataRow("Freight") = 41.38
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10633
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("10/13/1995 12:00:00 AM")
			dataRow("Freight") = 477.9
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10634
			dataRow("CustomerID") = "FOLIG"
			dataRow("RequiredDate") = DateTime.Parse("10/13/1995 12:00:00 AM")
			dataRow("Freight") = 487.38
			dataRow("ShipCity") = "Lille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10635
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("10/16/1995 12:00:00 AM")
			dataRow("Freight") = 47.46
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10636
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("10/17/1995 12:00:00 AM")
			dataRow("Freight") = 1.15
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10637
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("10/17/1995 12:00:00 AM")
			dataRow("Freight") = 201.29
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10638
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("10/18/1995 12:00:00 AM")
			dataRow("Freight") = 158.44
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10639
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("10/18/1995 12:00:00 AM")
			dataRow("Freight") = 38.64
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10640
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("10/19/1995 12:00:00 AM")
			dataRow("Freight") = 23.55
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10641
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("10/20/1995 12:00:00 AM")
			dataRow("Freight") = 179.61
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10642
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("10/20/1995 12:00:00 AM")
			dataRow("Freight") = 41.89
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10643
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("10/23/1995 12:00:00 AM")
			dataRow("Freight") = 29.46
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10644
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("10/23/1995 12:00:00 AM")
			dataRow("Freight") = 0.14
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10645
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("10/24/1995 12:00:00 AM")
			dataRow("Freight") = 12.41
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10646
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/8/1995 12:00:00 AM")
			dataRow("Freight") = 142.33
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10647
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("10/11/1995 12:00:00 AM")
			dataRow("Freight") = 45.54
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10648
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("11/9/1995 12:00:00 AM")
			dataRow("Freight") = 14.25
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10649
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("10/26/1995 12:00:00 AM")
			dataRow("Freight") = 6.2
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10650
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("10/27/1995 12:00:00 AM")
			dataRow("Freight") = 176.81
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10651
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("10/30/1995 12:00:00 AM")
			dataRow("Freight") = 20.6
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10652
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("10/30/1995 12:00:00 AM")
			dataRow("Freight") = 7.14
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10653
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("10/31/1995 12:00:00 AM")
			dataRow("Freight") = 93.25
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10654
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("10/31/1995 12:00:00 AM")
			dataRow("Freight") = 55.26
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10655
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("11/1/1995 12:00:00 AM")
			dataRow("Freight") = 4.41
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10656
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("11/2/1995 12:00:00 AM")
			dataRow("Freight") = 57.15
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10657
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("11/2/1995 12:00:00 AM")
			dataRow("Freight") = 352.69
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10658
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("11/3/1995 12:00:00 AM")
			dataRow("Freight") = 364.15
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10659
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("11/3/1995 12:00:00 AM")
			dataRow("Freight") = 105.81
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10660
			dataRow("CustomerID") = "HUNGC"
			dataRow("RequiredDate") = DateTime.Parse("11/6/1995 12:00:00 AM")
			dataRow("Freight") = 111.29
			dataRow("ShipCity") = "Elgin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10661
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/7/1995 12:00:00 AM")
			dataRow("Freight") = 17.55
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10662
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("11/7/1995 12:00:00 AM")
			dataRow("Freight") = 1.28
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10663
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("10/25/1995 12:00:00 AM")
			dataRow("Freight") = 113.15
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10664
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("11/8/1995 12:00:00 AM")
			dataRow("Freight") = 1.27
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10665
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("11/9/1995 12:00:00 AM")
			dataRow("Freight") = 26.31
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10666
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("11/10/1995 12:00:00 AM")
			dataRow("Freight") = 232.42
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10667
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("11/10/1995 12:00:00 AM")
			dataRow("Freight") = 78.09
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10668
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("11/13/1995 12:00:00 AM")
			dataRow("Freight") = 47.22
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10669
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("11/13/1995 12:00:00 AM")
			dataRow("Freight") = 24.39
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10670
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("11/14/1995 12:00:00 AM")
			dataRow("Freight") = 203.48
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10671
			dataRow("CustomerID") = "FRANR"
			dataRow("RequiredDate") = DateTime.Parse("11/15/1995 12:00:00 AM")
			dataRow("Freight") = 30.34
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10672
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("11/1/1995 12:00:00 AM")
			dataRow("Freight") = 95.75
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10673
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("11/16/1995 12:00:00 AM")
			dataRow("Freight") = 22.76
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10674
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("11/16/1995 12:00:00 AM")
			dataRow("Freight") = 0.9
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10675
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("11/17/1995 12:00:00 AM")
			dataRow("Freight") = 31.85
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10676
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("11/20/1995 12:00:00 AM")
			dataRow("Freight") = 2.01
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10677
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("11/20/1995 12:00:00 AM")
			dataRow("Freight") = 4.03
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10678
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("11/21/1995 12:00:00 AM")
			dataRow("Freight") = 388.98
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10679
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("11/21/1995 12:00:00 AM")
			dataRow("Freight") = 27.94
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10680
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("11/22/1995 12:00:00 AM")
			dataRow("Freight") = 26.61
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10681
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("11/23/1995 12:00:00 AM")
			dataRow("Freight") = 76.13
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10682
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("11/23/1995 12:00:00 AM")
			dataRow("Freight") = 36.13
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10683
			dataRow("CustomerID") = "DUMON"
			dataRow("RequiredDate") = DateTime.Parse("11/24/1995 12:00:00 AM")
			dataRow("Freight") = 4.4
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10684
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("11/24/1995 12:00:00 AM")
			dataRow("Freight") = 145.63
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10685
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("11/13/1995 12:00:00 AM")
			dataRow("Freight") = 33.75
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10686
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("11/28/1995 12:00:00 AM")
			dataRow("Freight") = 96.5
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10687
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/28/1995 12:00:00 AM")
			dataRow("Freight") = 296.43
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10688
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("11/15/1995 12:00:00 AM")
			dataRow("Freight") = 299.09
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10689
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("11/29/1995 12:00:00 AM")
			dataRow("Freight") = 13.42
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10690
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("11/30/1995 12:00:00 AM")
			dataRow("Freight") = 15.8
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10691
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("12/15/1995 12:00:00 AM")
			dataRow("Freight") = 810.05
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10692
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("12/1/1995 12:00:00 AM")
			dataRow("Freight") = 61.02
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10693
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("11/20/1995 12:00:00 AM")
			dataRow("Freight") = 139.34
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10694
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("12/4/1995 12:00:00 AM")
			dataRow("Freight") = 398.36
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10695
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("12/19/1995 12:00:00 AM")
			dataRow("Freight") = 16.72
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10696
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("12/20/1995 12:00:00 AM")
			dataRow("Freight") = 102.55
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10697
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("12/6/1995 12:00:00 AM")
			dataRow("Freight") = 45.52
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10698
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("12/7/1995 12:00:00 AM")
			dataRow("Freight") = 272.47
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10699
			dataRow("CustomerID") = "MORGK"
			dataRow("RequiredDate") = DateTime.Parse("12/7/1995 12:00:00 AM")
			dataRow("Freight") = 0.58
			dataRow("ShipCity") = "Leipzig"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10700
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("12/8/1995 12:00:00 AM")
			dataRow("Freight") = 65.1
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10701
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("11/27/1995 12:00:00 AM")
			dataRow("Freight") = 220.31
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10702
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("12/25/1995 12:00:00 AM")
			dataRow("Freight") = 23.94
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10703
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("12/12/1995 12:00:00 AM")
			dataRow("Freight") = 152.3
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10704
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("12/12/1995 12:00:00 AM")
			dataRow("Freight") = 4.78
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10705
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("12/13/1995 12:00:00 AM")
			dataRow("Freight") = 3.52
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10706
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("12/14/1995 12:00:00 AM")
			dataRow("Freight") = 135.63
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10707
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("11/30/1995 12:00:00 AM")
			dataRow("Freight") = 21.74
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10708
			dataRow("CustomerID") = "THEBI"
			dataRow("RequiredDate") = DateTime.Parse("12/29/1995 12:00:00 AM")
			dataRow("Freight") = 2.96
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10709
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("12/15/1995 12:00:00 AM")
			dataRow("Freight") = 210.8
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10710
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("12/18/1995 12:00:00 AM")
			dataRow("Freight") = 4.98
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10711
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("1/2/1996 12:00:00 AM")
			dataRow("Freight") = 52.41
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10712
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("12/19/1995 12:00:00 AM")
			dataRow("Freight") = 89.93
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10713
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("12/20/1995 12:00:00 AM")
			dataRow("Freight") = 167.05
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10714
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("12/20/1995 12:00:00 AM")
			dataRow("Freight") = 24.49
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10715
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("12/7/1995 12:00:00 AM")
			dataRow("Freight") = 63.2
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10716
			dataRow("CustomerID") = "RANCH"
			dataRow("RequiredDate") = DateTime.Parse("12/22/1995 12:00:00 AM")
			dataRow("Freight") = 22.57
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10717
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("12/22/1995 12:00:00 AM")
			dataRow("Freight") = 59.25
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10718
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("12/25/1995 12:00:00 AM")
			dataRow("Freight") = 170.88
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10719
			dataRow("CustomerID") = "LETSS"
			dataRow("RequiredDate") = DateTime.Parse("12/25/1995 12:00:00 AM")
			dataRow("Freight") = 51.44
			dataRow("ShipCity") = "San Francisco"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10720
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("12/12/1995 12:00:00 AM")
			dataRow("Freight") = 9.53
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10721
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("12/27/1995 12:00:00 AM")
			dataRow("Freight") = 48.92
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10722
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("1/10/1996 12:00:00 AM")
			dataRow("Freight") = 74.58
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10723
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("12/28/1995 12:00:00 AM")
			dataRow("Freight") = 21.72
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10724
			dataRow("CustomerID") = "MEREP"
			dataRow("RequiredDate") = DateTime.Parse("1/11/1996 12:00:00 AM")
			dataRow("Freight") = 57.75
			dataRow("ShipCity") = "Montréal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10725
			dataRow("CustomerID") = "FAMIA"
			dataRow("RequiredDate") = DateTime.Parse("12/29/1995 12:00:00 AM")
			dataRow("Freight") = 10.83
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10726
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("12/18/1995 12:00:00 AM")
			dataRow("Freight") = 16.56
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10727
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("1/1/1996 12:00:00 AM")
			dataRow("Freight") = 89.9
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10728
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("1/2/1996 12:00:00 AM")
			dataRow("Freight") = 58.33
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10729
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("1/16/1996 12:00:00 AM")
			dataRow("Freight") = 141.06
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10730
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("1/3/1996 12:00:00 AM")
			dataRow("Freight") = 20.12
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10731
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("1/4/1996 12:00:00 AM")
			dataRow("Freight") = 96.65
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10732
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("1/4/1996 12:00:00 AM")
			dataRow("Freight") = 16.97
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10733
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("1/5/1996 12:00:00 AM")
			dataRow("Freight") = 110.11
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10734
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("1/5/1996 12:00:00 AM")
			dataRow("Freight") = 1.63
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10735
			dataRow("CustomerID") = "LETSS"
			dataRow("RequiredDate") = DateTime.Parse("1/8/1996 12:00:00 AM")
			dataRow("Freight") = 45.97
			dataRow("ShipCity") = "San Francisco"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10736
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("1/9/1996 12:00:00 AM")
			dataRow("Freight") = 44.1
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10737
			dataRow("CustomerID") = "VINET"
			dataRow("RequiredDate") = DateTime.Parse("1/9/1996 12:00:00 AM")
			dataRow("Freight") = 7.79
			dataRow("ShipCity") = "Reims"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10738
			dataRow("CustomerID") = "SPECD"
			dataRow("RequiredDate") = DateTime.Parse("1/10/1996 12:00:00 AM")
			dataRow("Freight") = 2.91
			dataRow("ShipCity") = "Paris"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10739
			dataRow("CustomerID") = "VINET"
			dataRow("RequiredDate") = DateTime.Parse("1/10/1996 12:00:00 AM")
			dataRow("Freight") = 11.08
			dataRow("ShipCity") = "Reims"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10740
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("1/11/1996 12:00:00 AM")
			dataRow("Freight") = 81.88
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10741
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("12/29/1995 12:00:00 AM")
			dataRow("Freight") = 10.96
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10742
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("1/12/1996 12:00:00 AM")
			dataRow("Freight") = 243.73
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10743
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("1/15/1996 12:00:00 AM")
			dataRow("Freight") = 23.72
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10744
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("1/15/1996 12:00:00 AM")
			dataRow("Freight") = 69.19
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10745
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("1/16/1996 12:00:00 AM")
			dataRow("Freight") = 3.52
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10746
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("1/17/1996 12:00:00 AM")
			dataRow("Freight") = 31.43
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10747
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("1/17/1996 12:00:00 AM")
			dataRow("Freight") = 117.33
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10748
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("1/18/1996 12:00:00 AM")
			dataRow("Freight") = 232.55
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10749
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("1/18/1996 12:00:00 AM")
			dataRow("Freight") = 61.53
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10750
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("1/19/1996 12:00:00 AM")
			dataRow("Freight") = 79.3
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10751
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("1/22/1996 12:00:00 AM")
			dataRow("Freight") = 130.79
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10752
			dataRow("CustomerID") = "NORTS"
			dataRow("RequiredDate") = DateTime.Parse("1/22/1996 12:00:00 AM")
			dataRow("Freight") = 1.39
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10753
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("1/23/1996 12:00:00 AM")
			dataRow("Freight") = 7.7
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10754
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("1/23/1996 12:00:00 AM")
			dataRow("Freight") = 2.38
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10755
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("1/24/1996 12:00:00 AM")
			dataRow("Freight") = 16.71
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10756
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("1/25/1996 12:00:00 AM")
			dataRow("Freight") = 73.21
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10757
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("1/25/1996 12:00:00 AM")
			dataRow("Freight") = 8.19
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10758
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("1/26/1996 12:00:00 AM")
			dataRow("Freight") = 138.17
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10759
			dataRow("CustomerID") = "ANATR"
			dataRow("RequiredDate") = DateTime.Parse("1/26/1996 12:00:00 AM")
			dataRow("Freight") = 11.99
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10760
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("1/29/1996 12:00:00 AM")
			dataRow("Freight") = 155.64
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10761
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("1/30/1996 12:00:00 AM")
			dataRow("Freight") = 18.66
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10762
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("1/30/1996 12:00:00 AM")
			dataRow("Freight") = 328.74
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10763
			dataRow("CustomerID") = "FOLIG"
			dataRow("RequiredDate") = DateTime.Parse("1/31/1996 12:00:00 AM")
			dataRow("Freight") = 37.35
			dataRow("ShipCity") = "Lille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10764
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("1/31/1996 12:00:00 AM")
			dataRow("Freight") = 145.45
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10765
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("2/1/1996 12:00:00 AM")
			dataRow("Freight") = 42.74
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10766
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("2/2/1996 12:00:00 AM")
			dataRow("Freight") = 157.55
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10767
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("2/2/1996 12:00:00 AM")
			dataRow("Freight") = 1.59
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10768
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("2/5/1996 12:00:00 AM")
			dataRow("Freight") = 146.32
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10769
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("2/5/1996 12:00:00 AM")
			dataRow("Freight") = 65.06
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10770
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("2/6/1996 12:00:00 AM")
			dataRow("Freight") = 5.32
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10771
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/7/1996 12:00:00 AM")
			dataRow("Freight") = 11.19
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10772
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("2/7/1996 12:00:00 AM")
			dataRow("Freight") = 91.28
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10773
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/8/1996 12:00:00 AM")
			dataRow("Freight") = 96.43
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10774
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("1/25/1996 12:00:00 AM")
			dataRow("Freight") = 48.2
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10775
			dataRow("CustomerID") = "THECR"
			dataRow("RequiredDate") = DateTime.Parse("2/9/1996 12:00:00 AM")
			dataRow("Freight") = 20.25
			dataRow("ShipCity") = "Butte"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10776
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/12/1996 12:00:00 AM")
			dataRow("Freight") = 351.53
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10777
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("1/29/1996 12:00:00 AM")
			dataRow("Freight") = 3.01
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10778
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("2/13/1996 12:00:00 AM")
			dataRow("Freight") = 6.79
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10779
			dataRow("CustomerID") = "MORGK"
			dataRow("RequiredDate") = DateTime.Parse("2/13/1996 12:00:00 AM")
			dataRow("Freight") = 58.13
			dataRow("ShipCity") = "Leipzig"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10780
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("1/30/1996 12:00:00 AM")
			dataRow("Freight") = 42.13
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10781
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("2/14/1996 12:00:00 AM")
			dataRow("Freight") = 73.16
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10782
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("2/14/1996 12:00:00 AM")
			dataRow("Freight") = 1.1
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10783
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("2/15/1996 12:00:00 AM")
			dataRow("Freight") = 124.98
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10784
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("2/15/1996 12:00:00 AM")
			dataRow("Freight") = 70.09
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10785
			dataRow("CustomerID") = "GROSR"
			dataRow("RequiredDate") = DateTime.Parse("2/15/1996 12:00:00 AM")
			dataRow("Freight") = 1.51
			dataRow("ShipCity") = "Caracas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10786
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("2/16/1996 12:00:00 AM")
			dataRow("Freight") = 110.87
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10787
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("2/2/1996 12:00:00 AM")
			dataRow("Freight") = 249.93
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10788
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("2/19/1996 12:00:00 AM")
			dataRow("Freight") = 42.7
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10789
			dataRow("CustomerID") = "FOLIG"
			dataRow("RequiredDate") = DateTime.Parse("2/19/1996 12:00:00 AM")
			dataRow("Freight") = 100.6
			dataRow("ShipCity") = "Lille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10790
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("2/19/1996 12:00:00 AM")
			dataRow("Freight") = 28.23
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10791
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("2/20/1996 12:00:00 AM")
			dataRow("Freight") = 16.85
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10792
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("2/20/1996 12:00:00 AM")
			dataRow("Freight") = 23.79
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10793
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("2/21/1996 12:00:00 AM")
			dataRow("Freight") = 4.52
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10794
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("2/21/1996 12:00:00 AM")
			dataRow("Freight") = 21.49
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10795
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("2/21/1996 12:00:00 AM")
			dataRow("Freight") = 126.66
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10796
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("2/22/1996 12:00:00 AM")
			dataRow("Freight") = 26.52
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10797
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("2/22/1996 12:00:00 AM")
			dataRow("Freight") = 33.35
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10798
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("2/23/1996 12:00:00 AM")
			dataRow("Freight") = 2.33
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10799
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("3/8/1996 12:00:00 AM")
			dataRow("Freight") = 30.76
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10800
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("2/23/1996 12:00:00 AM")
			dataRow("Freight") = 137.44
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10801
			dataRow("CustomerID") = "BOLID"
			dataRow("RequiredDate") = DateTime.Parse("2/26/1996 12:00:00 AM")
			dataRow("Freight") = 97.09
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10802
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("2/26/1996 12:00:00 AM")
			dataRow("Freight") = 257.26
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10803
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("2/27/1996 12:00:00 AM")
			dataRow("Freight") = 55.23
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10804
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("2/27/1996 12:00:00 AM")
			dataRow("Freight") = 27.33
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10805
			dataRow("CustomerID") = "THEBI"
			dataRow("RequiredDate") = DateTime.Parse("2/27/1996 12:00:00 AM")
			dataRow("Freight") = 237.34
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10806
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("2/28/1996 12:00:00 AM")
			dataRow("Freight") = 22.11
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10807
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("2/28/1996 12:00:00 AM")
			dataRow("Freight") = 1.36
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10808
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("2/29/1996 12:00:00 AM")
			dataRow("Freight") = 45.53
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10809
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("2/29/1996 12:00:00 AM")
			dataRow("Freight") = 4.87
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10810
			dataRow("CustomerID") = "LAUGB"
			dataRow("RequiredDate") = DateTime.Parse("2/29/1996 12:00:00 AM")
			dataRow("Freight") = 4.33
			dataRow("ShipCity") = "Vancouver"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10811
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("3/1/1996 12:00:00 AM")
			dataRow("Freight") = 31.22
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10812
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("3/1/1996 12:00:00 AM")
			dataRow("Freight") = 59.78
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10813
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("3/4/1996 12:00:00 AM")
			dataRow("Freight") = 47.38
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10814
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("3/4/1996 12:00:00 AM")
			dataRow("Freight") = 130.94
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10815
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("3/4/1996 12:00:00 AM")
			dataRow("Freight") = 14.62
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10816
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("3/5/1996 12:00:00 AM")
			dataRow("Freight") = 719.78
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10817
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("2/20/1996 12:00:00 AM")
			dataRow("Freight") = 306.07
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10818
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("3/6/1996 12:00:00 AM")
			dataRow("Freight") = 65.48
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10819
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("3/6/1996 12:00:00 AM")
			dataRow("Freight") = 19.76
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10820
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("3/6/1996 12:00:00 AM")
			dataRow("Freight") = 37.52
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10821
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("3/7/1996 12:00:00 AM")
			dataRow("Freight") = 36.68
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10822
			dataRow("CustomerID") = "TRAIH"
			dataRow("RequiredDate") = DateTime.Parse("3/7/1996 12:00:00 AM")
			dataRow("Freight") = 7
			dataRow("ShipCity") = "Kirkland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10823
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("3/8/1996 12:00:00 AM")
			dataRow("Freight") = 163.97
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10824
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("3/8/1996 12:00:00 AM")
			dataRow("Freight") = 1.23
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10825
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("3/8/1996 12:00:00 AM")
			dataRow("Freight") = 79.25
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10826
			dataRow("CustomerID") = "BLONP"
			dataRow("RequiredDate") = DateTime.Parse("3/11/1996 12:00:00 AM")
			dataRow("Freight") = 7.09
			dataRow("ShipCity") = "Strasbourg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10827
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("2/26/1996 12:00:00 AM")
			dataRow("Freight") = 63.54
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10828
			dataRow("CustomerID") = "RANCH"
			dataRow("RequiredDate") = DateTime.Parse("2/27/1996 12:00:00 AM")
			dataRow("Freight") = 90.85
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10829
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("3/12/1996 12:00:00 AM")
			dataRow("Freight") = 154.72
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10830
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("3/26/1996 12:00:00 AM")
			dataRow("Freight") = 81.83
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10831
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("3/13/1996 12:00:00 AM")
			dataRow("Freight") = 72.19
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10832
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("3/13/1996 12:00:00 AM")
			dataRow("Freight") = 43.26
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10833
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("3/14/1996 12:00:00 AM")
			dataRow("Freight") = 71.49
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10834
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("3/14/1996 12:00:00 AM")
			dataRow("Freight") = 29.78
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10835
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("3/14/1996 12:00:00 AM")
			dataRow("Freight") = 69.53
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10836
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("3/15/1996 12:00:00 AM")
			dataRow("Freight") = 411.88
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10837
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("3/15/1996 12:00:00 AM")
			dataRow("Freight") = 13.32
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10838
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("3/18/1996 12:00:00 AM")
			dataRow("Freight") = 59.28
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10839
			dataRow("CustomerID") = "TRADH"
			dataRow("RequiredDate") = DateTime.Parse("3/18/1996 12:00:00 AM")
			dataRow("Freight") = 35.43
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10840
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("4/1/1996 12:00:00 AM")
			dataRow("Freight") = 2.71
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10841
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("3/19/1996 12:00:00 AM")
			dataRow("Freight") = 424.3
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10842
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("3/19/1996 12:00:00 AM")
			dataRow("Freight") = 54.42
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10843
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("3/20/1996 12:00:00 AM")
			dataRow("Freight") = 9.26
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10844
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("3/20/1996 12:00:00 AM")
			dataRow("Freight") = 25.22
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10845
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("3/6/1996 12:00:00 AM")
			dataRow("Freight") = 212.98
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10846
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("4/4/1996 12:00:00 AM")
			dataRow("Freight") = 56.46
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10847
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("3/7/1996 12:00:00 AM")
			dataRow("Freight") = 487.57
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10848
			dataRow("CustomerID") = "CONSH"
			dataRow("RequiredDate") = DateTime.Parse("3/22/1996 12:00:00 AM")
			dataRow("Freight") = 38.24
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10849
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("3/22/1996 12:00:00 AM")
			dataRow("Freight") = 0.56
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10850
			dataRow("CustomerID") = "VICTE"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1996 12:00:00 AM")
			dataRow("Freight") = 49.19
			dataRow("ShipCity") = "Lyon"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10851
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("3/25/1996 12:00:00 AM")
			dataRow("Freight") = 160.55
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10852
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("3/11/1996 12:00:00 AM")
			dataRow("Freight") = 174.05
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10853
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("3/26/1996 12:00:00 AM")
			dataRow("Freight") = 53.83
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10854
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("3/26/1996 12:00:00 AM")
			dataRow("Freight") = 100.22
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10855
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("3/26/1996 12:00:00 AM")
			dataRow("Freight") = 170.97
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10856
			dataRow("CustomerID") = "ANTON"
			dataRow("RequiredDate") = DateTime.Parse("3/27/1996 12:00:00 AM")
			dataRow("Freight") = 58.43
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10857
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("3/27/1996 12:00:00 AM")
			dataRow("Freight") = 188.85
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10858
			dataRow("CustomerID") = "LACOR"
			dataRow("RequiredDate") = DateTime.Parse("3/28/1996 12:00:00 AM")
			dataRow("Freight") = 52.51
			dataRow("ShipCity") = "Versailles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10859
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("3/28/1996 12:00:00 AM")
			dataRow("Freight") = 76.1
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10860
			dataRow("CustomerID") = "FRANR"
			dataRow("RequiredDate") = DateTime.Parse("3/28/1996 12:00:00 AM")
			dataRow("Freight") = 19.26
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10861
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("3/29/1996 12:00:00 AM")
			dataRow("Freight") = 14.93
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10862
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1996 12:00:00 AM")
			dataRow("Freight") = 53.23
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10863
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("4/1/1996 12:00:00 AM")
			dataRow("Freight") = 30.26
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10864
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("4/1/1996 12:00:00 AM")
			dataRow("Freight") = 3.04
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10865
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("3/18/1996 12:00:00 AM")
			dataRow("Freight") = 348.14
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10866
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("4/2/1996 12:00:00 AM")
			dataRow("Freight") = 109.11
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10867
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("4/16/1996 12:00:00 AM")
			dataRow("Freight") = 1.93
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10868
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("4/3/1996 12:00:00 AM")
			dataRow("Freight") = 191.27
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10869
			dataRow("CustomerID") = "SEVES"
			dataRow("RequiredDate") = DateTime.Parse("4/3/1996 12:00:00 AM")
			dataRow("Freight") = 143.28
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10870
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("4/3/1996 12:00:00 AM")
			dataRow("Freight") = 12.04
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10871
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("4/4/1996 12:00:00 AM")
			dataRow("Freight") = 112.27
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10872
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("4/4/1996 12:00:00 AM")
			dataRow("Freight") = 175.32
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10873
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1996 12:00:00 AM")
			dataRow("Freight") = 0.82
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10874
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1996 12:00:00 AM")
			dataRow("Freight") = 19.58
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10875
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("4/5/1996 12:00:00 AM")
			dataRow("Freight") = 32.37
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10876
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("4/8/1996 12:00:00 AM")
			dataRow("Freight") = 60.42
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10877
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("4/8/1996 12:00:00 AM")
			dataRow("Freight") = 38.06
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10878
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("4/9/1996 12:00:00 AM")
			dataRow("Freight") = 46.69
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10879
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("4/9/1996 12:00:00 AM")
			dataRow("Freight") = 8.5
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10880
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("4/23/1996 12:00:00 AM")
			dataRow("Freight") = 88.01
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10881
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("4/10/1996 12:00:00 AM")
			dataRow("Freight") = 2.84
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10882
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("4/10/1996 12:00:00 AM")
			dataRow("Freight") = 23.1
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10883
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("4/11/1996 12:00:00 AM")
			dataRow("Freight") = 0.53
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10884
			dataRow("CustomerID") = "LETSS"
			dataRow("RequiredDate") = DateTime.Parse("4/11/1996 12:00:00 AM")
			dataRow("Freight") = 90.97
			dataRow("ShipCity") = "San Francisco"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10885
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("4/11/1996 12:00:00 AM")
			dataRow("Freight") = 5.64
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10886
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1996 12:00:00 AM")
			dataRow("Freight") = 4.99
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10887
			dataRow("CustomerID") = "GALED"
			dataRow("RequiredDate") = DateTime.Parse("4/12/1996 12:00:00 AM")
			dataRow("Freight") = 1.25
			dataRow("ShipCity") = "Barcelona"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10888
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("4/15/1996 12:00:00 AM")
			dataRow("Freight") = 51.87
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10889
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("4/15/1996 12:00:00 AM")
			dataRow("Freight") = 280.61
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10890
			dataRow("CustomerID") = "DUMON"
			dataRow("RequiredDate") = DateTime.Parse("4/15/1996 12:00:00 AM")
			dataRow("Freight") = 32.76
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10891
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("4/16/1996 12:00:00 AM")
			dataRow("Freight") = 20.37
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10892
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("4/16/1996 12:00:00 AM")
			dataRow("Freight") = 120.27
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10893
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("4/17/1996 12:00:00 AM")
			dataRow("Freight") = 77.78
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10894
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("4/17/1996 12:00:00 AM")
			dataRow("Freight") = 116.13
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10895
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("4/17/1996 12:00:00 AM")
			dataRow("Freight") = 162.75
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10896
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("4/18/1996 12:00:00 AM")
			dataRow("Freight") = 32.45
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10897
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("4/18/1996 12:00:00 AM")
			dataRow("Freight") = 603.54
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10898
			dataRow("CustomerID") = "OCEAN"
			dataRow("RequiredDate") = DateTime.Parse("4/19/1996 12:00:00 AM")
			dataRow("Freight") = 1.27
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10899
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("4/19/1996 12:00:00 AM")
			dataRow("Freight") = 1.21
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10900
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("4/19/1996 12:00:00 AM")
			dataRow("Freight") = 1.66
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10901
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("4/22/1996 12:00:00 AM")
			dataRow("Freight") = 62.09
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10902
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("4/22/1996 12:00:00 AM")
			dataRow("Freight") = 44.15
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10903
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("4/23/1996 12:00:00 AM")
			dataRow("Freight") = 36.71
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10904
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("4/23/1996 12:00:00 AM")
			dataRow("Freight") = 162.95
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10905
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("4/23/1996 12:00:00 AM")
			dataRow("Freight") = 13.72
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10906
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("4/10/1996 12:00:00 AM")
			dataRow("Freight") = 26.29
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10907
			dataRow("CustomerID") = "SPECD"
			dataRow("RequiredDate") = DateTime.Parse("4/24/1996 12:00:00 AM")
			dataRow("Freight") = 9.19
			dataRow("ShipCity") = "Paris"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10908
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 32.96
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10909
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 53.05
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10910
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 38.11
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10911
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 38.19
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10912
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 580.91
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10913
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 33.05
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10914
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("4/26/1996 12:00:00 AM")
			dataRow("Freight") = 21.19
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10915
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("4/26/1996 12:00:00 AM")
			dataRow("Freight") = 3.51
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10916
			dataRow("CustomerID") = "RANCH"
			dataRow("RequiredDate") = DateTime.Parse("4/26/1996 12:00:00 AM")
			dataRow("Freight") = 63.77
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10917
			dataRow("CustomerID") = "ROMEY"
			dataRow("RequiredDate") = DateTime.Parse("4/29/1996 12:00:00 AM")
			dataRow("Freight") = 8.29
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10918
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("4/29/1996 12:00:00 AM")
			dataRow("Freight") = 48.83
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10919
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("4/29/1996 12:00:00 AM")
			dataRow("Freight") = 19.8
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10920
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("4/30/1996 12:00:00 AM")
			dataRow("Freight") = 29.61
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10921
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("5/14/1996 12:00:00 AM")
			dataRow("Freight") = 176.48
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10922
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("4/30/1996 12:00:00 AM")
			dataRow("Freight") = 62.74
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10923
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("5/14/1996 12:00:00 AM")
			dataRow("Freight") = 68.26
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10924
			dataRow("CustomerID") = "BERGS"
			dataRow("RequiredDate") = DateTime.Parse("5/1/1996 12:00:00 AM")
			dataRow("Freight") = 151.52
			dataRow("ShipCity") = "Luleå"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10925
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("5/1/1996 12:00:00 AM")
			dataRow("Freight") = 2.27
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10926
			dataRow("CustomerID") = "ANATR"
			dataRow("RequiredDate") = DateTime.Parse("5/1/1996 12:00:00 AM")
			dataRow("Freight") = 39.92
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10927
			dataRow("CustomerID") = "LACOR"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1996 12:00:00 AM")
			dataRow("Freight") = 19.79
			dataRow("ShipCity") = "Versailles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10928
			dataRow("CustomerID") = "GALED"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1996 12:00:00 AM")
			dataRow("Freight") = 1.36
			dataRow("ShipCity") = "Barcelona"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10929
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1996 12:00:00 AM")
			dataRow("Freight") = 33.93
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10930
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1996 12:00:00 AM")
			dataRow("Freight") = 15.55
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10931
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("4/19/1996 12:00:00 AM")
			dataRow("Freight") = 13.6
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10932
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("5/3/1996 12:00:00 AM")
			dataRow("Freight") = 134.64
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10933
			dataRow("CustomerID") = "ISLAT"
			dataRow("RequiredDate") = DateTime.Parse("5/3/1996 12:00:00 AM")
			dataRow("Freight") = 54.15
			dataRow("ShipCity") = "Cowes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10934
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("5/6/1996 12:00:00 AM")
			dataRow("Freight") = 32.01
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10935
			dataRow("CustomerID") = "WELLI"
			dataRow("RequiredDate") = DateTime.Parse("5/6/1996 12:00:00 AM")
			dataRow("Freight") = 47.59
			dataRow("ShipCity") = "Resende"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10936
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("5/6/1996 12:00:00 AM")
			dataRow("Freight") = 33.68
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10937
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("4/23/1996 12:00:00 AM")
			dataRow("Freight") = 31.51
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10938
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("5/7/1996 12:00:00 AM")
			dataRow("Freight") = 31.89
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10939
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("5/7/1996 12:00:00 AM")
			dataRow("Freight") = 76.33
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10940
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1996 12:00:00 AM")
			dataRow("Freight") = 19.77
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10941
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1996 12:00:00 AM")
			dataRow("Freight") = 400.81
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10942
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1996 12:00:00 AM")
			dataRow("Freight") = 17.95
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10943
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1996 12:00:00 AM")
			dataRow("Freight") = 2.17
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10944
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("4/25/1996 12:00:00 AM")
			dataRow("Freight") = 52.92
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10945
			dataRow("CustomerID") = "MORGK"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1996 12:00:00 AM")
			dataRow("Freight") = 10.22
			dataRow("ShipCity") = "Leipzig"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10946
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("5/9/1996 12:00:00 AM")
			dataRow("Freight") = 27.2
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10947
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("5/10/1996 12:00:00 AM")
			dataRow("Freight") = 3.26
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10948
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("5/10/1996 12:00:00 AM")
			dataRow("Freight") = 23.39
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10949
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("5/10/1996 12:00:00 AM")
			dataRow("Freight") = 74.44
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10950
			dataRow("CustomerID") = "MAGAA"
			dataRow("RequiredDate") = DateTime.Parse("5/13/1996 12:00:00 AM")
			dataRow("Freight") = 2.5
			dataRow("ShipCity") = "Bergamo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10951
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("5/27/1996 12:00:00 AM")
			dataRow("Freight") = 30.85
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10952
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("5/27/1996 12:00:00 AM")
			dataRow("Freight") = 40.42
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10953
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("4/29/1996 12:00:00 AM")
			dataRow("Freight") = 23.72
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10954
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 27.91
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10955
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("5/14/1996 12:00:00 AM")
			dataRow("Freight") = 3.26
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10956
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 44.65
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10957
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("5/15/1996 12:00:00 AM")
			dataRow("Freight") = 105.36
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10958
			dataRow("CustomerID") = "OCEAN"
			dataRow("RequiredDate") = DateTime.Parse("5/15/1996 12:00:00 AM")
			dataRow("Freight") = 49.56
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10959
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1996 12:00:00 AM")
			dataRow("Freight") = 4.98
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10960
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("5/2/1996 12:00:00 AM")
			dataRow("Freight") = 2.08
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10961
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("5/16/1996 12:00:00 AM")
			dataRow("Freight") = 104.47
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10962
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("5/16/1996 12:00:00 AM")
			dataRow("Freight") = 275.79
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10963
			dataRow("CustomerID") = "FURIB"
			dataRow("RequiredDate") = DateTime.Parse("5/16/1996 12:00:00 AM")
			dataRow("Freight") = 2.7
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10964
			dataRow("CustomerID") = "SPECD"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1996 12:00:00 AM")
			dataRow("Freight") = 87.38
			dataRow("ShipCity") = "Paris"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10965
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1996 12:00:00 AM")
			dataRow("Freight") = 144.38
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10966
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1996 12:00:00 AM")
			dataRow("Freight") = 27.19
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10967
			dataRow("CustomerID") = "TOMSP"
			dataRow("RequiredDate") = DateTime.Parse("5/20/1996 12:00:00 AM")
			dataRow("Freight") = 62.22
			dataRow("ShipCity") = "Münster"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10968
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("5/20/1996 12:00:00 AM")
			dataRow("Freight") = 74.6
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10969
			dataRow("CustomerID") = "COMMI"
			dataRow("RequiredDate") = DateTime.Parse("5/20/1996 12:00:00 AM")
			dataRow("Freight") = 0.21
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10970
			dataRow("CustomerID") = "BOLID"
			dataRow("RequiredDate") = DateTime.Parse("5/7/1996 12:00:00 AM")
			dataRow("Freight") = 16.16
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10971
			dataRow("CustomerID") = "FRANR"
			dataRow("RequiredDate") = DateTime.Parse("5/21/1996 12:00:00 AM")
			dataRow("Freight") = 121.82
			dataRow("ShipCity") = "Nantes"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10972
			dataRow("CustomerID") = "LACOR"
			dataRow("RequiredDate") = DateTime.Parse("5/21/1996 12:00:00 AM")
			dataRow("Freight") = 0.02
			dataRow("ShipCity") = "Versailles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10973
			dataRow("CustomerID") = "LACOR"
			dataRow("RequiredDate") = DateTime.Parse("5/21/1996 12:00:00 AM")
			dataRow("Freight") = 15.17
			dataRow("ShipCity") = "Versailles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10974
			dataRow("CustomerID") = "SPLIR"
			dataRow("RequiredDate") = DateTime.Parse("5/8/1996 12:00:00 AM")
			dataRow("Freight") = 12.96
			dataRow("ShipCity") = "Lander"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10975
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("5/22/1996 12:00:00 AM")
			dataRow("Freight") = 32.27
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10976
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1996 12:00:00 AM")
			dataRow("Freight") = 37.97
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10977
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("5/23/1996 12:00:00 AM")
			dataRow("Freight") = 208.5
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10978
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("5/23/1996 12:00:00 AM")
			dataRow("Freight") = 32.82
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10979
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("5/23/1996 12:00:00 AM")
			dataRow("Freight") = 353.07
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10980
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1996 12:00:00 AM")
			dataRow("Freight") = 1.26
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10981
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1996 12:00:00 AM")
			dataRow("Freight") = 193.37
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10982
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1996 12:00:00 AM")
			dataRow("Freight") = 14.01
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10983
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1996 12:00:00 AM")
			dataRow("Freight") = 657.54
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10984
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("5/27/1996 12:00:00 AM")
			dataRow("Freight") = 211.22
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10985
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("5/27/1996 12:00:00 AM")
			dataRow("Freight") = 91.51
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10986
			dataRow("CustomerID") = "OCEAN"
			dataRow("RequiredDate") = DateTime.Parse("5/27/1996 12:00:00 AM")
			dataRow("Freight") = 217.86
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10987
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 185.48
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10988
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 61.14
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10989
			dataRow("CustomerID") = "QUEDE"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 34.76
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10990
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("6/12/1996 12:00:00 AM")
			dataRow("Freight") = 117.61
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10991
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1996 12:00:00 AM")
			dataRow("Freight") = 38.51
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10992
			dataRow("CustomerID") = "THEBI"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1996 12:00:00 AM")
			dataRow("Freight") = 4.27
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10993
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("5/29/1996 12:00:00 AM")
			dataRow("Freight") = 8.81
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10994
			dataRow("CustomerID") = "VAFFE"
			dataRow("RequiredDate") = DateTime.Parse("5/16/1996 12:00:00 AM")
			dataRow("Freight") = 65.53
			dataRow("ShipCity") = "Århus"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10995
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("5/30/1996 12:00:00 AM")
			dataRow("Freight") = 46
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10996
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("5/30/1996 12:00:00 AM")
			dataRow("Freight") = 1.12
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10997
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1996 12:00:00 AM")
			dataRow("Freight") = 73.91
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10998
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("5/17/1996 12:00:00 AM")
			dataRow("Freight") = 20.31
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 10999
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("5/31/1996 12:00:00 AM")
			dataRow("Freight") = 96.35
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11000
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("6/3/1996 12:00:00 AM")
			dataRow("Freight") = 55.12
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11001
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("6/3/1996 12:00:00 AM")
			dataRow("Freight") = 197.3
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11002
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("6/3/1996 12:00:00 AM")
			dataRow("Freight") = 141.16
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11003
			dataRow("CustomerID") = "THECR"
			dataRow("RequiredDate") = DateTime.Parse("6/3/1996 12:00:00 AM")
			dataRow("Freight") = 14.91
			dataRow("ShipCity") = "Butte"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11004
			dataRow("CustomerID") = "MAISD"
			dataRow("RequiredDate") = DateTime.Parse("6/4/1996 12:00:00 AM")
			dataRow("Freight") = 44.84
			dataRow("ShipCity") = "Bruxelles"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11005
			dataRow("CustomerID") = "WILMK"
			dataRow("RequiredDate") = DateTime.Parse("6/4/1996 12:00:00 AM")
			dataRow("Freight") = 0.75
			dataRow("ShipCity") = "Helsinki"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11006
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("6/4/1996 12:00:00 AM")
			dataRow("Freight") = 25.19
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11007
			dataRow("CustomerID") = "PRINI"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1996 12:00:00 AM")
			dataRow("Freight") = 202.24
			dataRow("ShipCity") = "Lisboa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11008
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1996 12:00:00 AM")
			dataRow("Freight") = 79.46
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11009
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1996 12:00:00 AM")
			dataRow("Freight") = 59.11
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11010
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("6/6/1996 12:00:00 AM")
			dataRow("Freight") = 28.71
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11011
			dataRow("CustomerID") = "ALFKI"
			dataRow("RequiredDate") = DateTime.Parse("6/6/1996 12:00:00 AM")
			dataRow("Freight") = 1.21
			dataRow("ShipCity") = "Berlin"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11012
			dataRow("CustomerID") = "FRANK"
			dataRow("RequiredDate") = DateTime.Parse("5/23/1996 12:00:00 AM")
			dataRow("Freight") = 242.95
			dataRow("ShipCity") = "München"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11013
			dataRow("CustomerID") = "ROMEY"
			dataRow("RequiredDate") = DateTime.Parse("6/6/1996 12:00:00 AM")
			dataRow("Freight") = 32.99
			dataRow("ShipCity") = "Madrid"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11014
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1996 12:00:00 AM")
			dataRow("Freight") = 23.6
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11015
			dataRow("CustomerID") = "SANTG"
			dataRow("RequiredDate") = DateTime.Parse("5/24/1996 12:00:00 AM")
			dataRow("Freight") = 4.62
			dataRow("ShipCity") = "Stavern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11016
			dataRow("CustomerID") = "AROUT"
			dataRow("RequiredDate") = DateTime.Parse("6/7/1996 12:00:00 AM")
			dataRow("Freight") = 33.8
			dataRow("ShipCity") = "Colchester"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11017
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("6/10/1996 12:00:00 AM")
			dataRow("Freight") = 754.26
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11018
			dataRow("CustomerID") = "LONEP"
			dataRow("RequiredDate") = DateTime.Parse("6/10/1996 12:00:00 AM")
			dataRow("Freight") = 11.65
			dataRow("ShipCity") = "Portland"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11019
			dataRow("CustomerID") = "RANCH"
			dataRow("RequiredDate") = DateTime.Parse("6/10/1996 12:00:00 AM")
			dataRow("Freight") = 3.17
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11020
			dataRow("CustomerID") = "OTTIK"
			dataRow("RequiredDate") = DateTime.Parse("6/11/1996 12:00:00 AM")
			dataRow("Freight") = 43.3
			dataRow("ShipCity") = "Köln"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11021
			dataRow("CustomerID") = "QUICK"
			dataRow("RequiredDate") = DateTime.Parse("6/11/1996 12:00:00 AM")
			dataRow("Freight") = 297.18
			dataRow("ShipCity") = "Cunewalde"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11022
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("6/11/1996 12:00:00 AM")
			dataRow("Freight") = 6.27
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11023
			dataRow("CustomerID") = "BSBEV"
			dataRow("RequiredDate") = DateTime.Parse("5/28/1996 12:00:00 AM")
			dataRow("Freight") = 123.83
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11024
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("6/12/1996 12:00:00 AM")
			dataRow("Freight") = 74.36
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11025
			dataRow("CustomerID") = "WARTH"
			dataRow("RequiredDate") = DateTime.Parse("6/12/1996 12:00:00 AM")
			dataRow("Freight") = 29.17
			dataRow("ShipCity") = "Oulu"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11026
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("6/12/1996 12:00:00 AM")
			dataRow("Freight") = 47.09
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11027
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("6/13/1996 12:00:00 AM")
			dataRow("Freight") = 52.52
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11028
			dataRow("CustomerID") = "KOENE"
			dataRow("RequiredDate") = DateTime.Parse("6/13/1996 12:00:00 AM")
			dataRow("Freight") = 29.59
			dataRow("ShipCity") = "Brandenburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11029
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("6/13/1996 12:00:00 AM")
			dataRow("Freight") = 47.84
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11030
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1996 12:00:00 AM")
			dataRow("Freight") = 830.75
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11031
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1996 12:00:00 AM")
			dataRow("Freight") = 227.22
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11032
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1996 12:00:00 AM")
			dataRow("Freight") = 606.19
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11033
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("6/14/1996 12:00:00 AM")
			dataRow("Freight") = 84.74
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11034
			dataRow("CustomerID") = "OLDWO"
			dataRow("RequiredDate") = DateTime.Parse("7/1/1996 12:00:00 AM")
			dataRow("Freight") = 40.32
			dataRow("ShipCity") = "Anchorage"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11035
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("6/17/1996 12:00:00 AM")
			dataRow("Freight") = 0.17
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11036
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("6/17/1996 12:00:00 AM")
			dataRow("Freight") = 149.47
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11037
			dataRow("CustomerID") = "GODOS"
			dataRow("RequiredDate") = DateTime.Parse("6/18/1996 12:00:00 AM")
			dataRow("Freight") = 3.2
			dataRow("ShipCity") = "Sevilla"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11038
			dataRow("CustomerID") = "SUPRD"
			dataRow("RequiredDate") = DateTime.Parse("6/18/1996 12:00:00 AM")
			dataRow("Freight") = 29.59
			dataRow("ShipCity") = "Charleroi"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11039
			dataRow("CustomerID") = "LINOD"
			dataRow("RequiredDate") = DateTime.Parse("6/18/1996 12:00:00 AM")
			dataRow("Freight") = 65
			dataRow("ShipCity") = "I. de Margarita"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11040
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("6/19/1996 12:00:00 AM")
			dataRow("Freight") = 18.84
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11041
			dataRow("CustomerID") = "CHOPS"
			dataRow("RequiredDate") = DateTime.Parse("6/19/1996 12:00:00 AM")
			dataRow("Freight") = 48.22
			dataRow("ShipCity") = "Bern"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11042
			dataRow("CustomerID") = "COMMI"
			dataRow("RequiredDate") = DateTime.Parse("6/5/1996 12:00:00 AM")
			dataRow("Freight") = 29.99
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11043
			dataRow("CustomerID") = "SPECD"
			dataRow("RequiredDate") = DateTime.Parse("6/19/1996 12:00:00 AM")
			dataRow("Freight") = 8.8
			dataRow("ShipCity") = "Paris"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11044
			dataRow("CustomerID") = "WOLZA"
			dataRow("RequiredDate") = DateTime.Parse("6/20/1996 12:00:00 AM")
			dataRow("Freight") = 8.72
			dataRow("ShipCity") = "Warszawa"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11045
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("6/20/1996 12:00:00 AM")
			dataRow("Freight") = 70.58
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11046
			dataRow("CustomerID") = "WANDK"
			dataRow("RequiredDate") = DateTime.Parse("6/20/1996 12:00:00 AM")
			dataRow("Freight") = 71.64
			dataRow("ShipCity") = "Stuttgart"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11047
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("6/21/1996 12:00:00 AM")
			dataRow("Freight") = 46.62
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11048
			dataRow("CustomerID") = "BOTTM"
			dataRow("RequiredDate") = DateTime.Parse("6/21/1996 12:00:00 AM")
			dataRow("Freight") = 24.12
			dataRow("ShipCity") = "Tsawassen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11049
			dataRow("CustomerID") = "GOURL"
			dataRow("RequiredDate") = DateTime.Parse("6/21/1996 12:00:00 AM")
			dataRow("Freight") = 8.34
			dataRow("ShipCity") = "Campinas"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11050
			dataRow("CustomerID") = "FOLKO"
			dataRow("RequiredDate") = DateTime.Parse("6/24/1996 12:00:00 AM")
			dataRow("Freight") = 59.41
			dataRow("ShipCity") = "Bräcke"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11051
			dataRow("CustomerID") = "LAMAI"
			dataRow("RequiredDate") = DateTime.Parse("6/24/1996 12:00:00 AM")
			dataRow("Freight") = 2.79
			dataRow("ShipCity") = "Toulouse"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11052
			dataRow("CustomerID") = "HANAR"
			dataRow("RequiredDate") = DateTime.Parse("6/24/1996 12:00:00 AM")
			dataRow("Freight") = 67.26
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11053
			dataRow("CustomerID") = "PICCO"
			dataRow("RequiredDate") = DateTime.Parse("6/24/1996 12:00:00 AM")
			dataRow("Freight") = 53.05
			dataRow("ShipCity") = "Salzburg"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11054
			dataRow("CustomerID") = "CACTU"
			dataRow("RequiredDate") = DateTime.Parse("6/25/1996 12:00:00 AM")
			dataRow("Freight") = 0.33
			dataRow("ShipCity") = "Buenos Aires"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11055
			dataRow("CustomerID") = "HILAA"
			dataRow("RequiredDate") = DateTime.Parse("6/25/1996 12:00:00 AM")
			dataRow("Freight") = 120.92
			dataRow("ShipCity") = "San Cristóbal"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11056
			dataRow("CustomerID") = "EASTC"
			dataRow("RequiredDate") = DateTime.Parse("6/11/1996 12:00:00 AM")
			dataRow("Freight") = 278.96
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11057
			dataRow("CustomerID") = "NORTS"
			dataRow("RequiredDate") = DateTime.Parse("6/26/1996 12:00:00 AM")
			dataRow("Freight") = 4.13
			dataRow("ShipCity") = "London"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11058
			dataRow("CustomerID") = "BLAUS"
			dataRow("RequiredDate") = DateTime.Parse("6/26/1996 12:00:00 AM")
			dataRow("Freight") = 31.14
			dataRow("ShipCity") = "Mannheim"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11059
			dataRow("CustomerID") = "RICAR"
			dataRow("RequiredDate") = DateTime.Parse("7/10/1996 12:00:00 AM")
			dataRow("Freight") = 85.8
			dataRow("ShipCity") = "Rio de Janeiro"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11060
			dataRow("CustomerID") = "FRANS"
			dataRow("RequiredDate") = DateTime.Parse("6/27/1996 12:00:00 AM")
			dataRow("Freight") = 10.98
			dataRow("ShipCity") = "Torino"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11061
			dataRow("CustomerID") = "GREAL"
			dataRow("RequiredDate") = DateTime.Parse("7/11/1996 12:00:00 AM")
			dataRow("Freight") = 14.01
			dataRow("ShipCity") = "Eugene"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11062
			dataRow("CustomerID") = "REGGC"
			dataRow("RequiredDate") = DateTime.Parse("6/27/1996 12:00:00 AM")
			dataRow("Freight") = 29.93
			dataRow("ShipCity") = "Reggio Emilia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11063
			dataRow("CustomerID") = "HUNGO"
			dataRow("RequiredDate") = DateTime.Parse("6/27/1996 12:00:00 AM")
			dataRow("Freight") = 81.73
			dataRow("ShipCity") = "Cork"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11064
			dataRow("CustomerID") = "SAVEA"
			dataRow("RequiredDate") = DateTime.Parse("6/28/1996 12:00:00 AM")
			dataRow("Freight") = 30.09
			dataRow("ShipCity") = "Boise"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11065
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("6/28/1996 12:00:00 AM")
			dataRow("Freight") = 12.91
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11066
			dataRow("CustomerID") = "WHITC"
			dataRow("RequiredDate") = DateTime.Parse("6/28/1996 12:00:00 AM")
			dataRow("Freight") = 44.72
			dataRow("ShipCity") = "Seattle"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11067
			dataRow("CustomerID") = "DRACD"
			dataRow("RequiredDate") = DateTime.Parse("6/17/1996 12:00:00 AM")
			dataRow("Freight") = 7.98
			dataRow("ShipCity") = "Aachen"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11068
			dataRow("CustomerID") = "QUEEN"
			dataRow("RequiredDate") = DateTime.Parse("7/1/1996 12:00:00 AM")
			dataRow("Freight") = 81.75
			dataRow("ShipCity") = "São Paulo"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11069
			dataRow("CustomerID") = "TORTU"
			dataRow("RequiredDate") = DateTime.Parse("7/1/1996 12:00:00 AM")
			dataRow("Freight") = 15.67
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11070
			dataRow("CustomerID") = "LEHMS"
			dataRow("RequiredDate") = DateTime.Parse("7/2/1996 12:00:00 AM")
			dataRow("Freight") = 136
			dataRow("ShipCity") = "Frankfurt a.M. "
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11071
			dataRow("CustomerID") = "LILAS"
			dataRow("RequiredDate") = DateTime.Parse("7/2/1996 12:00:00 AM")
			dataRow("Freight") = 0.93
			dataRow("ShipCity") = "Barquisimeto"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11072
			dataRow("CustomerID") = "ERNSH"
			dataRow("RequiredDate") = DateTime.Parse("7/2/1996 12:00:00 AM")
			dataRow("Freight") = 258.64
			dataRow("ShipCity") = "Graz"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11073
			dataRow("CustomerID") = "PERIC"
			dataRow("RequiredDate") = DateTime.Parse("7/2/1996 12:00:00 AM")
			dataRow("Freight") = 24.95
			dataRow("ShipCity") = "México D.F."
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11074
			dataRow("CustomerID") = "SIMOB"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1996 12:00:00 AM")
			dataRow("Freight") = 18.44
			dataRow("ShipCity") = "København"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11075
			dataRow("CustomerID") = "RICSU"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1996 12:00:00 AM")
			dataRow("Freight") = 6.19
			dataRow("ShipCity") = "Genève"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11076
			dataRow("CustomerID") = "BONAP"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1996 12:00:00 AM")
			dataRow("Freight") = 38.28
			dataRow("ShipCity") = "Marseille"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("OrderID") = 11077
			dataRow("CustomerID") = "RATTC"
			dataRow("RequiredDate") = DateTime.Parse("7/3/1996 12:00:00 AM")
			dataRow("Freight") = 8.53
			dataRow("ShipCity") = "Albuquerque"
			table.Rows.Add(dataRow)

			Return table
		End Function
	End Class
End Namespace
