from graphviz import Source
from .NodoLS import NodoLS

class ListaSimple(object):
	
	def __init__(self):
		self.inicio = None
		self.fin = None
		self.indice = 0
		self.grafo = ""
		
	def estaVacia(self):
		if self.inicio == None:
			return True
		else:
			return False

	def insertarInicio(self, carnet, ip, mascara):
		nuevo = NodoLS(self.indice, carnet, ip, mascara)
		
		if self.estaVacia() == True:
			self.inicio = self.fin = nuevo
		else:
			nuevo.siguiente = self.inicio
			self.inicio = nuevo

		self.indice += 1

	def insertarFinal(self, carnet, ip, mascara):
		nuevo = NodoLS(self.indice, carnet, ip, mascara)

		if self.estaVacia() == True:
			self.inicio = self.fin = nuevo
		else:
			self.fin.siguiente = nuevo
			self.fin = nuevo

		self.indice += 1

	def buscarPalabra(self, ip):
		temp = self.inicio
		encontrado = False

		while temp != None and encontrado != True:
			if ip == temp.getIP():
				encontrado = True
				return "IP " + temp.getIP() + " encontrada en el indice " + str(temp.getIndice())
			else:
				temp = temp.siguiente
		return "Palabra No Encontrada!"

	def mostrar(self):
		if self.estaVacia() == True:
			print ("Lista Vacia")
		else:
			temp = self.inicio
			while temp != None:
				print (temp.getCarnet() , "--" , temp.getIP())
				temp = temp.siguiente				

	def eliminarIndice(self, indice):
		if self.inicio.getIndice() == indice:
			self.inicio = self.inicio.siguiente
			self.indice = self.indice - 1
			if self.fin.getIndice() == indice:
				self.fin = None
		else:
			temp = self.inicio
			while temp != None:
				if temp.siguiente != None:
					if temp.siguiente.getIndice() == indice:
						temp.siguiente = temp.siguiente.siguiente
						if self.fin.getIndice() == indice:
							self.fin = temp
						self.indice = self.indice - 1
				temp = temp.siguiente				

	def graficar(self):
		"""dot = Digraph(comment='Lista Simple',format='jpg',node_attr={'shape':'box'},name='Lista Simple')
		dot.graph_attr['rankdir']='UD'
		dot  #doctest: +ELLIPSIS
		temp = self.inicio
		if temp == None:
			print ("Lista vacia")
			dot.node("1","Lista Vacia")
			dot.render('test-output/ListaSimple', view = True)
		else:
			print (temp.getIndice())
			print (temp.getCarnet())
			while temp != None:				
				dot.node(str(temp.getIndice()), str(temp.getCarnet()), str(temp.getIP()))
				if temp.siguiente != None:
					dot.node(str(temp.siguiente.getIndice()), str(temp.siguiente.getCarnet()), str(temp.getIP()))
					dot.edge(str(temp.getIndice()), str(temp.siguiente.getIndice()), constraint='false')
				print (temp.getIndice())
				print (temp.getCarnet())
				temp = temp.siguiente
			print(dot.source)
			dot.render('test-output/ListaSimple', view = True)"""
		self.grafo = "digraph G {\n" + "graph [rankdir = TB];\n" + "node [shape = record,height=.1];  {\n"

		if self.estaVacia() == True:
			self.grafo += "\"ListaVacia\" [label = \"Lista Vacia\"]"
		else:
			temp = self.inicio
			i = 0
			while temp != None:
				self.grafo += "\"" + str(i) + "\" [label = \"" + "Carnet: " +str(temp.getCarnet())
				self.grafo += "\\nIP: " + str(temp.getIP()) + "\"];\n"
				if i > 0:
					self.grafo +=  "\"" + str(i - 1) + "\" -> \"" + str(i) + "\" ;\n"

				temp = temp.siguiente
				i = i + 1

		self.grafo += "} labelloc=\"t\"; label=\" LISTA SIMPLE\";}"
		print(self.grafo)
		src = Source(self.grafo)
		src.format = "png"
		src.render('test-output/ListaSimple', view = True)