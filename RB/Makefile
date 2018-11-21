CXXFLAGS=-g -Iinc -Wall -pedantic --std=c++11

FabrykaOG: main.o Robot.o Przeszkoda.o Wektor2D.o\
           lacze_do_gnuplota.o Scena.o ObiektGraficzny.o ZbiorWierzcholkow.o Sciezka.o Fabryka.o
	g++ -Wall -pedantic -std=c++0x -o Fabryka main.o Wektor2D.o \
                         Robot.o lacze_do_gnuplota.o Scena.o ObiektGraficzny.o ZbiorWierzcholkow.o Przeszkoda.o Sciezka.o Fabryka.o

Scena.o: Scena.hh Scena.cpp
	g++ -c ${CXXFLAGS} -o Scena.o Scena.cpp

Fabryka.o: Fabryka.hh Fabryka.cpp
	g++ -c ${CXXFLAGS} -o Fabryka.o Fabryka.cpp

ObiektGraficzny.o: ObiektGraficzny.hh ObiektGraficzny.cpp
	g++ -c ${CXXFLAGS} -o ObiektGraficzny.o ObiektGraficzny.cpp

Przeszkoda.o: Przeszkoda.hh Przeszkoda.cpp
	g++ -c ${CXXFLAGS} -o Przeszkoda.o Przeszkoda.cpp

ZbiorWierzcholkow.o: ZbiorWierzcholkow.hh ZbiorWierzcholkow.cpp
	g++ -c ${CXXFLAGS} -o ZbiorWierzcholkow.o ZbiorWierzcholkow.cpp

Sciezka.o: Sciezka.hh Sciezka.cpp
	g++ -c ${CXXFLAGS} -o Sciezka.o Sciezka.cpp

lacze_do_gnuplota.o: lacze_do_gnuplota.hh lacze_do_gnuplota.cpp
	g++ -c ${CXXFLAGS} -o lacze_do_gnuplota.o lacze_do_gnuplota.cpp

main.o: main.cpp Robot.hh Wektor2D.hh Scena.hh ObiektGraficzny.hh Sciezka.hh
	g++ -c ${CXXFLAGS} -o main.o main.cpp

Robot.o: Robot.cpp Robot.hh
	g++ -c ${CXXFLAGS} -o Robot.o Robot.cpp

Wektor2D.o: Wektor2D.cpp Wektor2D.hh
	g++ -c ${CXXFLAGS} -o Wektor2D.o Wektor2D.cpp

clean:
	rm -f *.o Fabryka
