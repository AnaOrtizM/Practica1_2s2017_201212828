class NodoCola(object):
	def __init__ (self, indice, carnet, ip, mensaje):
		self.indice = indice
		self.carnet = carnet
		self.ip = ip
		self.mensaje = mensaje
		self.siguiente = None

	def getIndice(self):
		return self.indice

	def getCarnet(self):
		return self.carnet

	def getIP(self):
		return self.ip

	def getMensaje(self):
		return self.mensaje