from graphviz import Source
from .NodoPila import NodoPila

class Pila(object):
	
	def __init__(self):
		self.inicio = None
		self.fin = None
		self.indice = 0
		
	def estaVacia(self):
		if self.inicio == None:
			return True
		else:
			return False

	def push(self, dato):
		nuevo = NodoPila(self.indice, dato)

		if self.estaVacia() == True:
			self.inicio = self.fin = nuevo
		else:
			nuevo.anterior = self.fin
			self.fin.siguiente = nuevo
			self.fin = nuevo

		self.indice += 1

	def mostrar(self):
		if self.estaVacia() == True:
			print ("Pila Vacia")
		else:
			temp = self.fin
			while temp != None:
				print (temp.getIndice() , "--" , temp.getDato())
				temp = temp.anterior

	def pop(self, dato):
		if self.estaVacia() == False:
			temp = self.fin
			if self.fin == self.inicio:
				self.inicio = self.fin = None
			else:
				self.fin = self.fin.anterior
				self.fin.siguiente = None
			self.indice = self.indice - 1
			print ("Dato " , str(temp.getDato()) , "eliminado")
			return temp.getDato()

	def graficar(self):
		self.grafo = "digraph G {\n" + "graph [rankdir = UD];\n" + "node [shape = doublecircle,height=.1];  {\n"

		if self.estaVacia() == True:
			self.grafo += "\"PilaVacia\" [label = \"Pila Vacia\"]"
		else:
			temp = self.inicio
			i = 0
			while temp != None:
				self.grafo += "\"" + str(i) + "\" [label = \"" + "Dato: " + str(temp.getDato()) + "\"];\n"
				if i > 0:
					self.grafo +=  "\"" + str(i - 1) + "\" -> \"" + str(i) + "\" ;\n"

				temp = temp.siguiente
				i = i + 1

		self.grafo += "} labelloc=\"t\"; label=\" PILA\";}"
		print(self.grafo)
		src = Source(self.grafo)
		src.format = "png"
		src.render('test-output/Pila', view = True)