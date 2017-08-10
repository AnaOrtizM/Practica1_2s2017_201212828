from graphviz import Source
from .NodoLD import NodoLD

class ListaDoble(object):
	
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

	def insertarInicio(self, carnet, ip, mensaje):
		nuevo = NodoLD(self.indice, carnet, ip, mensaje)
		
		if self.estaVacia() == True:
			self.inicio = self.fin = nuevo
		else:
			nuevo.siguiente = self.inicio
			self.inicio.anterior = nuevo
			self.inicio = nuevo

		self.indice += 1

	def insertarFinal(self, carnet, ip, mensaje):
		nuevo = NodoLD(self.indice, carnet, ip, mensaje)

		if self.estaVacia() == True:
			self.fin = self.inicio = nuevo
		else:
			nuevo.anterior = self.fin
			self.fin.siguiente = nuevo
			self.fin = nuevo

		self.indice += 1		

	def buscar(self, carnet):
		temp = self.inicio
		encontrado = False

		while temp != None and encontrado != True:
			if temp.getCarnet() == carnet:
				encontrado = True
				print("Carnet: " + temp.getCarnet() + " encontrado en el indice " + str(temp.getIndice()))
				return temp
			else:
				temp = temp.siguiente
		return None

	def mostrarInicioFin(self):
		if self.estaVacia() == True:
			print ("Lista Vacia")
		else:
			temp = self.inicio
			while temp != None:
				print (temp.getCarnet() , "--" , temp.getIP() , "--" , temp.getMsj())
				temp = temp.siguiente

	def mostrarFinInicio(self):
		if self.estaVacia() == True:
			print ("Lista Vacia")
		else:
			temp = self.fin
			while temp != None:
				print (temp.getCarnet() , "--" , temp.getIP() , "--" , temp.getMsj())
				temp = temp.anterior			

	def eliminarIndice(self, indice):
		if self.inicio != None:
			temp = self.inicio
			temp2 = None
			while temp != self.fin:
				if temp.getIndice() == indice:
					if temp2 == None:
						self.inicio = self.inicio.siguiente
						self.inicio.anterior = None
						temp.siguiente = None
						temp = self.inicio
					else:
						temp2.siguiente = temp.siguiente
						temp2.siguiente.anterior = temp.anterior
						temp.siguiente = None
						temp = temp2.siguiente
				else:
					temp2 = temp
					temp = temp.siguiente


			if indice == temp.getIndice():
				self.fin = temp.anterior
				self.fin.siguiente = None

	"""def verificarUsuario(self, nombre, password):
		usuario = self.buscar(nombre)
		if (nombre == usuario.getNombre()) and ( password == usuario.getPassword()):
			print ("Usuario " + usuario.getNombre() + " correcto")
			return True
		else:
			print ("Usuario " + usuario.getNombre() + " incorrecto")
			return False"""

	def graficar(self):
		self.grafo = "digraph G {\n" + "graph [rankdir = TB];\n" + "node [shape = record,height=.1];  {\n"

		if self.estaVacia() == True:
			self.grafo += "\"ListaVacia\" [label = \"Lista Vacia\"]"
		else:
			temp = self.inicio
			i = 0
			while temp != None:
				self.grafo += "\"" + str(i) + "\" [label = \"" + "Carnet: " + temp.getCarnet() 
				self.grafo += "\\nIP: " + temp.getIP()
				self.grafo += "\\nMensaje: " + temp.getMsj() + "\"];\n"
				if i > 0:
					self.grafo +=  "\"" + str(i - 1) + "\" -> \"" + str(i) + "\" ;\n"
					self.grafo +=  "\"" + str(i) + "\" -> \"" + str(i - 1) + "\" ;\n"

				temp = temp.siguiente
				i = i + 1

		self.grafo += "} labelloc=\"t\"; label=\" LISTA DOBLE\";}"
		print(self.grafo)
		src = Source(self.grafo)
		src.format = "png"
		src.render('test-output/ListaDoble', view = True)
#**************************************************************************#