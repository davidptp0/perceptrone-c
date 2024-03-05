using system


    class Perceptron(){
        def __init__(){
            Random rnd = new Random();
            doudle patterns = [
                [0,0],
                [0,1],
                [1,0],
                [1.1]
            ];
            answer = [0,0,0,1];
            synapsis = [rnd.next() + 0.00001 for (int i = 0; i < 2; i++)];
            neurons = [1];
            enters = [];

        }
        def count_neurins(){


            double neurons[0] = 0
            for(int i = 0;i < enters.length(); i++){

                neurons[0] += synapsis[i] * enters[i];
            }
        neurons[0] = neurons[0] > 0.5 ? 1 : 0;
        }

        def study(){

            double g_error = 1;
            while (g_error > 0){
                g_error = 0;
                for (int i = 0; i < patterns.length(); i++){

                    enters = patterns;
                    count_neurins();
                    double l_error = answers[i] - neurons[0];
                    for (int j = 0; j < synapsis.length();j++){

                        synapsis[j] += 0.1 * l_error * enters[j];
                    g_error += Math.abs(l_error);
                    }
                    
                }

            }
        
        }

    }
        def main(){
        p = Perceptron()

        p.study()
        for (int i = 0; i < patterns.length()){

            p.enters = pattern;
            p.count_neurins();
            Console.WriteLine(p.neurons);
        }
    }
    if __name__ == "main"{
        main();
    }