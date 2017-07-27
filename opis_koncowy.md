# Opis końcowy projektu "Edytor tekstu"

Link do filmiku : https://www.youtube.com/watch?v=JwX51bh30ks

W tym projekcie użyliśmy już wielu gotowych fukncji z Windows Forms m. in. takie jak kopiowanie, wklejanie, cofanie itd.

Przy niektórych musieliśmy dodać pare rzeczy od siebie takich jak w zapisywaniu żeby było zależne od nazwy pliku, bo jeżeli ją ma to 
fukncja zapisywania normalnego działa inaczej i nie wymaga podawania nazwy tylko zapisuje na już nadaną nazwę pliku.

Część funkcjonalności programu jest zależne od tego czy zawartość pliku była zmieniana, ponieważ jeżeli tak było to program ma zachować się inaczej
jest tak w otwieraniu pliku, zamykaniu programu, tworzeniu nowego pliku. Gdy w pliku było coś zmienione to program pyta się pierw czy zapisać 
zmiany które były w nim zrobione, czy nie zapisywać tych zmian, bądź anulować tą akcję.

Zmiana czcionki, koloru czcinki jest zrobiona przy pomocy gotowych fukncji do tego tylko trochę zmienionych, a zmiana tła zawartości jest dostępna 
lecz nie wiedziliśmy jak zapisać to do pliku, ay i w pliku był ten kolor tła.

Opcje wyrównania tekstu są zrobione w ten sposób, że w menu może być kliknięta tylko jedna opcja i są zrobione przy pomocy funkcji 
SelectionAlignment zależnej od zaznaczonej strefy a nie całego pliku.

Przy pogrubieniu/kursywie/podkreśleniu był problem w czasie gdy zaznaczone były dwie różne czcionki przez co element SelectionFont był równy null 
przez co był błąd, rozwiązaliśmy go algorytmem sprawdzania tekstu sekcyjnie, gdzie każda sekcja była częścią zaznaczonego tekstu z tą samą czcionką, 
dzięki czemu można było m. in. pogrubić. Niestety nie zdołaliśmy rozwiązać problemu cofania tego procesu kiedy są dwie różne czcionki. Udało nam 
się tylko zrobić to w stronę gdzie się dodawało tą właściwość tekstu. Zaś jeżeli była tylko jedna czcionka to wszystko działało bez zarzutu.