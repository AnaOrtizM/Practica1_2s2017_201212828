from flask import Flask, request, Response

#********** IMPORTACIONES DE CLASES **********#

from ListaSimple.ListaSimple import ListaSimple
from ListaDoble.ListaDoble import ListaDoble
from Cola.Cola import Cola
from Pila.Pila import Pila
#*********************************************#
app = Flask('Practica1_Servidor')

#********** INSTANCIAMIENTO DE CLASES **********#
ls = ListaSimple()
ld = ListaDoble()
cl = Cola()
pl = Pila()
#***********************************************#

#********** METODOS LISTA SIMPLE **********#
ls.insertarFinal("201212828","192.168.0.1","255.255.255.0")
ls.insertarFinal("201213295","192.168.0.2","255.255.255.0")
ls.mostrar()
ls.graficar()
"""@app.route('/insertarLista',methods=['POST']) 
#@app.route('/insertarLista') 
def insertarLista():
	#parametro = str(request.args['palabra'])
	parametro = str(request.form['palabra'])
	ls.insertarFinal(str(parametro))
	ls.mostrar()
	return "Palabra insertada con exito!"	

@app.route('/buscarLista',methods=['POST']) 
#@app.route('/buscarLista') 
def buscarLista():
	#parametro = str(request.args['indice'])
	parametro = str(request.form['palabra'])
	return str(ls.buscarPalabra(str(parametro)))

@app.route('/eliminarLista',methods=['POST']) 
#@app.route('/eliminarLista') 
def eliminarLista():
	#parametro = str(request.args['indice'])
	parametro = str(request.form['indice'])
	ls.eliminarIndice(int(parametro))
	ls.mostrar()
	return "Palabra" + str(parametro) + "eliminada"  

@app.route('/graficarLista',methods=['POST']) 
#@app.route('/eliminarLista') 
def graficarLista():
	ls.graficar()
	return "Lista Graficada" """
#******************************************#

#*********** METODOS LISTA DOBLE **********#
ld.insertarFinal("201214505", "192.168.0.3", "(2+2)")
ld.insertarFinal("201348796", "192.168.0.10", "(4*5)")
ld.mostrarInicioFin()
ld.graficar()
#******************************************#

#************* METODOS  COLA  *************#
cl.queue("201212829", "192.168.0.5", "((4*5)+(6*7))")
cl.queue("201401527", "192.168.0.6", "(((3+1)*5)+7)")
cl.mostrar()
cl.graficar()
"""@app.route('/queueCola',methods=['POST']) 
#@app.route('/insertarLista') 
def queueCola():
	#parametro = str(request.args['palabra'])
	parametro = str(request.form['dato'])
	cl.queue(str(parametro))
	cl.mostrar()
	return "Dato insertado con exito!"	

@app.route('/dequeueCola',methods=['POST']) 
#@app.route('/eliminarLista') 
def dequeueCola():
	#parametro = str(request.args['indice'])
	parametro = str(request.form['dato'])
	resultado = cl.dequeue(str(parametro))
	cl.mostrar()
	return "Dato " + resultado + " eliminado" 

@app.route('/graficarCola',methods=['POST']) 
#@app.route('/eliminarLista') 
def graficarCola():
	cl.graficar()
	return "Cola Graficada" """
#******************************************#

#************* METODOS  PILA  *************#
pl.push(8)
pl.push(7)
pl.push("+")
pl.mostrar()
pl.graficar()
"""@app.route('/pushPila',methods=['POST']) 
#@app.route('/insertarLista') 
def pushPila():
	#parametro = str(request.args['palabra'])
	parametro = str(request.form['dato'])
	pl.push(str(parametro))
	pl.mostrar()
	return "Dato insertado con exito!"	

@app.route('/popPila',methods=['POST']) 
#@app.route('/eliminarLista') 
def popPila():
	#parametro = str(request.args['indice'])
	parametro = str(request.form['dato'])
	resultado = pl.pop(str(parametro))
	#pl.pop(str(parametro))
	pl.mostrar()
	return "Dato " + resultado + " eliminado" 

@app.route('/graficarPila',methods=['POST']) 
#@app.route('/eliminarLista') 
def graficarPila():
	pl.graficar()
	return "Pila Graficada" """
#******************************************#
if __name__ == "__main__":
	print("Servidor iniciado...")
	app.run(debug=True, host='127.0.0.1')