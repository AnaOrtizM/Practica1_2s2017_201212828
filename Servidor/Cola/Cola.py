from graphviz import Source
from .NodoCola import NodoCola

class Cola(object):
	
	def __init__(self):
		self.inicio = None
		self.fin = None
		self.indice = 0
		
	def estaVacia(self):
		if self.inicio == None:
			return True
		else:
			return False

	def queue(self, carnet, ip, mensaje):
		nuevo = NodoCola(self.indice, carnet, ip, mensaje)

		if self.estaVacia() == True:
			self.inicio = self.fin = nuevo
		else:
			self.fin.siguiente = nuevo
			self.fin = nuevo

		self.indice += 1

	def mostrar(self):
		if self.estaVacia() == True:
			print ("Cola Vacia")
		else:
			temp = self.inicio
			while temp != None:
				print (temp.getIP() , "--" , temp.getMensaje())
				temp = temp.siguiente

	def dequeue(self, carnet):
		if self.estaVacia() == False:
			temp = self.inicio
			self.inicio = self.inicio.siguiente
			if self.estaVacia() == True:
				self.fin = None
			self.indice = self.indice - 1
			print ("Dato " , str(temp.getCarnet()) , "eliminado")
		return temp.getCarnet()

	def graficar(self):
		"""dot = Digraph(comment='Cola',format='jpg',node_attr={'shape':'circle'},name='Cola')
		dot.graph_attr['rankdir']='UD'
		dot  #doctest: +ELLIPSIS
		temp = self.inicio
		if temp == None:
			print ("Cola vacia")
			dot.node("1","Cola Vacia")
			dot.render('test-output/Cola', view = True)
		else:
			print (temp.getIndice())
			print (temp.getDato())
			while temp != None:				
				dot.node(str(temp.getIndice()), temp.getDato())
				if temp.siguiente != None:
					dot.node(str(temp.siguiente.getIndice()), temp.siguiente.getDato())
					dot.edge(str(temp.getIndice()), str(temp.siguiente.getIndice()), constraint='false')
				print (temp.getIndice())
				print (temp.getDato())
				temp = temp.siguiente
			print(dot.source)
			dot.render('test-output/Cola', view = True)"""

		self.grafo = "digraph G {\n" + "graph [rankdir = UD];\n" + "node [shape = oval,height=.1];  {\n"

		if self.estaVacia() == True:
			self.grafo += "\"ColaVacia\" [label = \"Cola Vacia\"]"
		else:
			temp = self.inicio
			i = 0
			while temp != None:
				self.grafo += "\"" + str(i) + "\" [label = \"" + "Carnet: " +str(temp.getCarnet())
				self.grafo += "\\nIP: " + str(temp.getIP())
				self.grafo += "\\nMsj: " + str(temp.getMensaje()) + "\"];\n"
				if i > 0:
					self.grafo +=  "\"" + str(i - 1) + "\" -> \"" + str(i) + "\" ;\n"

				temp = temp.siguiente
				i = i + 1

		self.grafo += "} labelloc=\"t\"; label=\" COLA\";}"
		print(self.grafo)
		src = Source(self.grafo)
		src.format = "png"
		src.render('test-output/Cola', view = True)