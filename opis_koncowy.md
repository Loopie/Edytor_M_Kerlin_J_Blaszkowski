# Opis końcowy projektu "Edytor tekstu"

Link do filmiku : https://www.youtube.com/watch?v=JwX51bh30ks

W tym projekcie użyliśmy już wielu gotowych funkcji z Windows Forms m. in. takich jak kopiowanie, wklejanie, cofanie itd.

Przy niektórych funkcjonalnościach musieliśmy dodać pare rzeczy od siebie, takich jak przy zapisywaniu, żeby było zależne od nazwy pliku, bo jeżeli ją ma to 
fukncja zapisywania normalnego działa inaczej i nie wymaga podawania nazwy tylko zapisuje na już nadaną nazwę pliku.

Część funkcjonalności programu jest zależna od tego czy zawartość pliku była zmieniana, ponieważ jeżeli tak było to program ma zachować się inaczej
jest tak np. przy otwieraniu pliku, zamykaniu programu, tworzeniu nowego pliku. Gdy w pliku było coś zmienione to program pyta się wpierw czy zapisać 
zmiany które były w nim zrobione, czy nie zapisywać tych zmian, bądź anulować tą akcję.

Zmiana czcionki, koloru czcionki jest zrobiona przy pomocy gotowych funkcji. Zmiana koloru tła jest dostępna, lecz nie zapisuje się do pliku.

Opcje wyrównania tekstu są zrobione w ten sposób, że na 'toolbarze' może być kliknięta tylko jedna opcja i są zrobione przy pomocy funkcji 
SelectionAlignment zależnej od zaznaczonej strefy a nie całego pliku.

Przy pogrubieniu/kursywie/podkreśleniu był problem w czasie gdy zaznaczone były dwie różne czcionki przez co element SelectionFont był równy null 
przez co był błąd, rozwiązaliśmy go algorytmem sprawdzania tekstu sekcyjnie, gdzie każda sekcja była częścią zaznaczonego tekstu z tą samą czcionką, 
dzięki czemu można było m. in. pogrubić. Niestety nie zdołaliśmy rozwiązać problemu cofania tego procesu kiedy są dwie różne czcionki. Udało nam 
się tylko zrobić to w stronę gdzie się dodawało tą właściwość tekstu. Zaś jeżeli była tylko jedna czcionka to wszystko działało bez zarzutu.
