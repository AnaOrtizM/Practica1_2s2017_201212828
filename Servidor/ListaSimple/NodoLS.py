class NodoLS(object):
	def __init__ (self, indice, carnet, ip, mascara):
		self.indice = indice
		self.carnet = carnet
		self.ip = ip
		self.mascara = mascara
		self.siguiente = None

	def getIndice(self):
		return self.indice

	def getCarnet(self):
		return self.carnet

	def getIP(self):
		return self.ip

	def getMascara(self):
		return self.mascara
