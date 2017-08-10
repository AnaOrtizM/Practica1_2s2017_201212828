class NodoLDU(object):
	def __init__ (self, indice, carnet, ip):
		self.indice = indice
		self.carnet = carnet
		self.ip = ip
		self.anterior = None
		self.siguiente = None

	def getIndice(self):
		return self.indice

	def getCarnet(self):
		return self.carnet

	def getIP(self):
		return self.ip