import React, { Component } from 'react';
import './App.css';
import LstFiverrItem from './Components/LstFiverrItem';

class App extends Component {

  state = {
    isLoaded: false,
    arrFiverrItem: [
      {
        id: 1,
        client: 'Eu',
        intPriority: 1,
        nvcDescription: 'teste',
        dtmDeadline: '22-06-2020',
        bitIsDone: false
      },
      {
        id: 2,
        client: 'Lili',
        intPriority: 2,
        nvcDescription: 'Prenda',
        dtmDeadline: '22-06-2020',
        bitIsDone: false
      }
    ]
  }

  componentDidMount() {

    fetch('https://localhost:44313/api/Fiverr')
    
      .then(res => res.json())
      .then(json => {
        this.setState({
          isLoaded: true,
          arrFiverrItem: json
        })
      })
  }

  render() {

    var { isLoaded, arrFiverrItem} = this.state;

    if (!isLoaded) {

      return <div>Loading...</div>
    } else {

      
        return (
          <div>
            <LstFiverrItem arrFiverrItem={this.state.arrFiverrItem} />
          </div>
      )
    }
  }
}

export default App;
