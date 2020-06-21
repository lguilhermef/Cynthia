import React, { Component } from 'react';
import './App.css';
import LstFiverrItem from './Components/LstFiverrItem';
import TopNavBar from './Components/TopNavBar';

class App extends Component {

  state = {
    isLoaded: false,
    arrFiverrItem: []
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
            <TopNavBar/>
            <LstFiverrItem arrFiverrItem={this.state.arrFiverrItem} />
          </div>
      )
    }
  }
}

export default App;
